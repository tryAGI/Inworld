#nullable enable
#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated; opt in.

using System.Runtime.CompilerServices;
using Meai = Microsoft.Extensions.AI;

namespace Inworld;

/// <summary>
/// Implements <see cref="Meai.ISpeechToTextClient"/> on <see cref="InworldClient"/>.
/// <para>
/// Non-streaming <c>GetTextAsync</c> uses the REST <c>/stt/v1/transcribe</c>
/// endpoint. Streaming <c>GetStreamingTextAsync</c> opens a WebSocket
/// connection to <c>/stt/v1/transcribe:streamBidirectional</c>, sends the
/// audio stream in chunks, and yields interim + final transcription updates.
/// </para>
/// </summary>
public partial class InworldClient : Meai.ISpeechToTextClient
{
    private Meai.SpeechToTextClientMetadata? _speechMetadata;

    private const string DefaultRestModelId = "inworld/inworld-stt-v1";
    private const string DefaultStreamingModelId = "inworld/inworld-stt-v1";

    /// <inheritdoc />
    object? Meai.ISpeechToTextClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        if (serviceKey is not null)
        {
            return null;
        }

        if (serviceType == typeof(Meai.SpeechToTextClientMetadata))
        {
            return _speechMetadata ??= new("inworld", BaseUri);
        }

        return serviceType.IsInstanceOfType(this) ? this : null;
    }

    /// <inheritdoc />
    async Task<Meai.SpeechToTextResponse> Meai.ISpeechToTextClient.GetTextAsync(
        Stream audioSpeechStream,
        Meai.SpeechToTextOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(audioSpeechStream);

        using var memoryStream = new MemoryStream();
        await audioSpeechStream.CopyToAsync(memoryStream, cancellationToken).ConfigureAwait(false);
        var audioBytes = memoryStream.ToArray();

        var request = new TranscribeRequest
        {
            TranscribeConfig = new TranscribeConfig
            {
                ModelId = options?.ModelId is { Length: > 0 } m ? m : DefaultRestModelId,
                Language = options?.SpeechLanguage,
                AudioEncoding = SttAudioEncoding.AutoDetect,
                IncludeWordTimestamps = true,
            },
            AudioData = new AudioData
            {
                Content = audioBytes,
            },
        };

        var response = await SpeechToText.TranscribeAudioAsync(
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var text = response.Transcription?.Transcript ?? string.Empty;
        TimeSpan? endTime = response.Usage?.TranscribedAudioMs is int ms && ms > 0
            ? TimeSpan.FromMilliseconds(ms)
            : null;

        return new Meai.SpeechToTextResponse(text)
        {
            RawRepresentation = response,
            ModelId = response.Usage?.ModelId,
            StartTime = TimeSpan.Zero,
            EndTime = endTime,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<Meai.SpeechToTextResponseUpdate> Meai.ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream,
        Meai.SpeechToTextOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(audioSpeechStream);

        // Extract the API key from the REST authorizations list so the WS
        // client can authenticate with the same credentials.
        string? apiKey = null;
        for (int i = 0; i < Authorizations.Count; i++)
        {
            var auth = Authorizations[i];
            if (auth is { Type: "Http", Value: { Length: > 0 } value })
            {
                apiKey = value;
                break;
            }
        }

        if (apiKey is null)
        {
            throw new InvalidOperationException(
                "No API key found in InworldClient.Authorizations. Construct the client with an API key or JWT.");
        }

        var realtime = new Realtime.InworldSpeechToTextStreamRealtimeClient(apiKey);
        await using (realtime.ConfigureAwait(false))
        {
            await realtime.ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);

            var sampleRate = options?.AdditionalProperties?.TryGetValue("sampleRateHertz", out var srObj) == true
                && srObj is int sr ? sr : 16000;

            await realtime.SendSttConfigureAsync(
                new Realtime.SttConfigure
                {
                    TranscribeConfig = new Realtime.SttTranscribeConfigParams
                    {
                        ModelId = options?.ModelId is { Length: > 0 } m ? m : DefaultStreamingModelId,
                        Language = options?.SpeechLanguage,
                        AudioEncoding = "LINEAR16",
                        SampleRateHertz = sampleRate,
                        NumberOfChannels = 1,
                    },
                },
                cancellationToken: cancellationToken).ConfigureAwait(false);

            string? responseId = Guid.NewGuid().ToString("N");
            yield return new Meai.SpeechToTextResponseUpdate
            {
                Kind = Meai.SpeechToTextResponseUpdateKind.SessionOpen,
                ResponseId = responseId,
            };

            var sendTask = Task.Run(async () =>
            {
                try
                {
                    var buffer = new byte[8192];
                    int bytesRead;
                    while ((bytesRead = await audioSpeechStream.ReadAsync(
                        buffer.AsMemory(0, buffer.Length),
                        cancellationToken).ConfigureAwait(false)) > 0)
                    {
                        var slice = new byte[bytesRead];
                        Array.Copy(buffer, slice, bytesRead);
                        await realtime.SendSttAudioChunkAsync(
                            new Realtime.SttAudioChunk
                            {
                                AudioChunk = new Realtime.SttAudioChunkData
                                {
                                    Content = slice,
                                },
                            },
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                    }

                    await realtime.SendSttCloseStreamAsync(
                        new Realtime.SttCloseStream
                        {
                            CloseStream = new Realtime.SttCloseStreamCloseStream(),
                        },
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                }
                catch (OperationCanceledException)
                {
                }
            }, cancellationToken);

            await foreach (var @event in realtime.ReceiveUpdatesAsync(cancellationToken).ConfigureAwait(false))
            {
                if (@event.IsSttTranscription && @event.SttTranscription?.Result?.Transcription is { } tx)
                {
                    var kind = tx.IsFinal == true
                        ? Meai.SpeechToTextResponseUpdateKind.TextUpdated
                        : Meai.SpeechToTextResponseUpdateKind.TextUpdating;

                    yield return new Meai.SpeechToTextResponseUpdate(tx.Transcript ?? string.Empty)
                    {
                        Kind = kind,
                        ResponseId = responseId,
                        RawRepresentation = @event.SttTranscription,
                    };
                }
                else if (@event.IsSttStarted && @event.SttStarted?.Result?.SpeechStarted is { } started)
                {
                    // No MEAI kind directly models a VAD "speech-started" signal;
                    // surface it as an empty TextUpdating with StartTime populated
                    // and the raw event attached for callers that care.
                    yield return new Meai.SpeechToTextResponseUpdate
                    {
                        Kind = Meai.SpeechToTextResponseUpdateKind.TextUpdating,
                        ResponseId = responseId,
                        StartTime = started.StartTimeMs is int startMs ? TimeSpan.FromMilliseconds(startMs) : null,
                        RawRepresentation = @event.SttStarted,
                    };
                }
                else if (@event.IsSttUsage)
                {
                    // End of stream — close session.
                    break;
                }
            }

            yield return new Meai.SpeechToTextResponseUpdate
            {
                Kind = Meai.SpeechToTextResponseUpdateKind.SessionClose,
                ResponseId = responseId,
            };

            try
            {
                await sendTask.ConfigureAwait(false);
            }
            catch (OperationCanceledException)
            {
            }
        }
    }
}
