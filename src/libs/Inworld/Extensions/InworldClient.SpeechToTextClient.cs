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

    private const string DefaultRestModelId = "inworld/inworld-stt-1";
    private const string DefaultStreamingModelId = "inworld/inworld-stt-1";

    /// <summary>
    /// The legacy/documented model id that Inworld's streaming STT does not
    /// actually serve (see
    /// https://github.com/inworld-ai/inworld-api-examples/issues/71). We
    /// silently rewrite it to the correct id to avoid the opaque
    /// <c>"No STT client found for model: inworld/stt-v1"</c> error.
    /// </summary>
    public const string LegacyInworldSttModelId = "inworld/stt-v1";

    /// <summary>
    /// The currently-deployed Inworld-branded streaming STT model id.
    /// </summary>
    public const string CurrentInworldSttModelId = "inworld/inworld-stt-1";

    /// <summary>
    /// When <c>true</c> (default), the first call that passes
    /// <see cref="LegacyInworldSttModelId"/> logs a one-shot
    /// <see cref="System.Diagnostics.Trace.TraceWarning(string, object[])"/>
    /// pointing at the upstream issue. Set to <c>false</c> in CI test suites
    /// that intentionally exercise the rewrite so the warning does not spam
    /// the build log.
    /// </summary>
    public static bool EnableLegacyModelIdWarning { get; set; } = true;

    private static int s_warnedLegacyStt;

    private static string NormalizeSttModelId(string? requested, string fallback)
    {
        if (string.IsNullOrEmpty(requested))
        {
            return fallback;
        }

        if (string.Equals(requested, LegacyInworldSttModelId, StringComparison.Ordinal))
        {
            if (EnableLegacyModelIdWarning &&
                System.Threading.Interlocked.Exchange(ref s_warnedLegacyStt, 1) == 0)
            {
                System.Diagnostics.Trace.TraceWarning(
                    "[Inworld] STT model id '{0}' is rewritten to '{1}' — the documented id is not deployed on the streaming endpoint. See https://github.com/inworld-ai/inworld-api-examples/issues/71. Set InworldClient.EnableLegacyModelIdWarning = false to suppress.",
                    LegacyInworldSttModelId,
                    CurrentInworldSttModelId);
            }
            return CurrentInworldSttModelId;
        }

        return requested;
    }

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
                ModelId = NormalizeSttModelId(options?.ModelId, DefaultRestModelId),
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
            // Pass the right scheme (Basic for Portal keys, Bearer for JWTs)
            // via additionalHeaders — this overrides the stored Bearer header
            // that the generated client would otherwise apply.
            await realtime.ConnectAsync(
                additionalHeaders: Realtime.InworldRealtimeAuth.BuildConnectHeaders(apiKey),
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var sampleRate = options?.AdditionalProperties?.TryGetValue("sampleRateHertz", out var srObj) == true
                && srObj is int sr ? sr : 16000;

            await realtime.SendSttConfigureAsync(
                new Realtime.SttConfigure
                {
                    TranscribeConfig = new Realtime.SttTranscribeConfigParams
                    {
                        ModelId = NormalizeSttModelId(options?.ModelId, DefaultStreamingModelId),
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

            // AutoSDK >= 0.30.1-dev.244 scores nested properties in oneOf
            // discriminators (tryAGI/AutoSDK#281), so the generated
            // ReceiveUpdatesAsync now dispatches Inworld's `{"result": ...}`
            // envelopes correctly.
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

    /// <summary>
    /// Parse a single Inworld STT server frame into a MEAI update.
    /// <para>
    /// Every frame is shaped <c>{"result": {...}}</c>; the real discriminator
    /// is the inner key (<c>transcription</c> / <c>usage</c> /
    /// <c>speechStarted</c>). Returns <c>(null, false)</c> for frames that
    /// don't map to a meaningful MEAI update (e.g. empty / malformed), and
    /// <c>endOfStream=true</c> for the usage frame that signals the end of
    /// the transcription stream.
    /// </para>
    /// </summary>
    [CLSCompliant(false)]
    public static (Meai.SpeechToTextResponseUpdate? update, bool endOfStream) ParseServerFrame(
        string json,
        string? responseId)
    {
        ArgumentNullException.ThrowIfNull(json);

        using var doc = System.Text.Json.JsonDocument.Parse(json);
        if (!doc.RootElement.TryGetProperty("result", out var result))
        {
            return (null, false);
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

            return (new Meai.SpeechToTextResponseUpdate(text)
            {
                Kind = kind,
                ResponseId = responseId,
                RawRepresentation = json,
            }, false);
        }

        if (result.TryGetProperty("speechStarted", out var started))
        {
            int? startMs = started.TryGetProperty("startTimeMs", out var smsProp) &&
                           smsProp.ValueKind == System.Text.Json.JsonValueKind.Number
                ? smsProp.GetInt32() : null;

            return (new Meai.SpeechToTextResponseUpdate
            {
                Kind = Meai.SpeechToTextResponseUpdateKind.TextUpdating,
                ResponseId = responseId,
                StartTime = startMs is int v ? TimeSpan.FromMilliseconds(v) : null,
                RawRepresentation = json,
            }, false);
        }

        if (result.TryGetProperty("usage", out _))
        {
            // End of stream — no more transcription updates.
            return (null, true);
        }

        return (null, false);
    }
}
