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

    private const string DefaultRestModelId = "inworld/stt-v1";
    private const string DefaultStreamingModelId = "assemblyai/universal-streaming-multilingual";

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

        // Prefer a dynamic token provider (JwtCache or similar) when set so
        // long-running WebSocket sessions start with a freshly-minted JWT.
        // Fall back to whatever token was passed at construction time.
        string? apiKey = null;
        if (RealtimeTokenProvider is { } provider)
        {
            apiKey = await provider(cancellationToken).ConfigureAwait(false);
        }

        if (string.IsNullOrEmpty(apiKey))
        {
            for (int i = 0; i < Authorizations.Count; i++)
            {
                var auth = Authorizations[i];
                if (auth is { Type: "Http", Value: { Length: > 0 } value })
                {
                    apiKey = value;
                    break;
                }
            }
        }

        if (string.IsNullOrEmpty(apiKey))
        {
            throw new InvalidOperationException(
                "No API key found. Construct the client with an API key, a JWT, or an InworldJwtCache, or set RealtimeTokenProvider.");
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

                    // The generated SttCloseStreamCloseStream type has a
                    // `JsonExtensionData Dictionary<string, object>`, which the
                    // source-gen serializer can't roundtrip. Send the literal
                    // control message instead — it has no payload fields.
                    await realtime.SendAsync(
                        "{\"close_stream\":{}}",
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                }
                catch (OperationCanceledException)
                {
                }
            }, cancellationToken);

            // The generated SpeechToTextStreamServerEvent discriminator only
            // inspects top-level properties, but every Inworld server message
            // is `{"result": {...}}` — the real discriminator is the inner key
            // (`transcription`, `usage`, or `speechStarted`). Parse the raw
            // WebSocket frames by hand to route events correctly.
            var ws = realtime.RawWebSocket
                ?? throw new InvalidOperationException("Realtime WebSocket is not available.");

            var readBuffer = new byte[64 * 1024];
            while (ws.State == System.Net.WebSockets.WebSocketState.Open &&
                   !cancellationToken.IsCancellationRequested)
            {
                var segment = new ArraySegment<byte>(readBuffer);
                System.Net.WebSockets.WebSocketReceiveResult rcv;
                try
                {
                    rcv = await ws.ReceiveAsync(segment, cancellationToken).ConfigureAwait(false);
                }
                catch (System.Net.WebSockets.WebSocketException)
                {
                    break;
                }
                catch (OperationCanceledException)
                {
                    break;
                }

                if (rcv.MessageType == System.Net.WebSockets.WebSocketMessageType.Close)
                {
                    break;
                }

                if (rcv.MessageType != System.Net.WebSockets.WebSocketMessageType.Text)
                {
                    continue;
                }

                var json = System.Text.Encoding.UTF8.GetString(readBuffer, 0, rcv.Count);
                using var doc = System.Text.Json.JsonDocument.Parse(json);
                if (!doc.RootElement.TryGetProperty("result", out var result))
                {
                    continue;
                }

                if (result.TryGetProperty("transcription", out var tr))
                {
                    string text = tr.TryGetProperty("transcript", out var txProp) && txProp.ValueKind == System.Text.Json.JsonValueKind.String
                        ? txProp.GetString() ?? string.Empty
                        : string.Empty;
                    bool isFinal = tr.TryGetProperty("isFinal", out var finProp) && finProp.ValueKind == System.Text.Json.JsonValueKind.True;

                    var kind = isFinal
                        ? Meai.SpeechToTextResponseUpdateKind.TextUpdated
                        : Meai.SpeechToTextResponseUpdateKind.TextUpdating;

                    yield return new Meai.SpeechToTextResponseUpdate(text)
                    {
                        Kind = kind,
                        ResponseId = responseId,
                        RawRepresentation = json,
                    };
                }
                else if (result.TryGetProperty("speechStarted", out var started))
                {
                    int? startMs = started.TryGetProperty("startTimeMs", out var smsProp) &&
                                   smsProp.ValueKind == System.Text.Json.JsonValueKind.Number
                        ? smsProp.GetInt32() : null;

                    yield return new Meai.SpeechToTextResponseUpdate
                    {
                        Kind = Meai.SpeechToTextResponseUpdateKind.TextUpdating,
                        ResponseId = responseId,
                        StartTime = startMs is int v ? TimeSpan.FromMilliseconds(v) : null,
                        RawRepresentation = json,
                    };
                }
                else if (result.TryGetProperty("usage", out _))
                {
                    // End of stream — no more transcription updates.
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
