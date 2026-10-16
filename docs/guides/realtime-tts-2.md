# Realtime TTS-2

The SDK supports the callable capabilities in the [TTS-2 announcement](https://inworld.ai/blog/realtime-tts-2).
Wire fields below follow the current API reference, which differs from some launch examples.

| Capability | SDK surface |
| --- | --- |
| TTS-2 and TTS-2 Flash | `InworldTtsModels.RealtimeTts2` and `RealtimeTts2Flash` |
| Natural-language voice direction | `SynthesizeSpeechRequest.Instruction` and inline `[speak ...]` tags (TTS-2) |
| Non-verbals and disfluencies | Text passes through unchanged, including `[laugh]`, `[sigh]`, `[breathe]`, fillers, and pauses |
| Crosslingual speech | Mix languages in `Text`; omit `Language` for automatic detection, or supply a supported BCP-47 language/locale |
| Stability/expressiveness | Synthesis `DeliveryMode.Stable`, `.Balanced`, or `.Creative` |
| Prior text context | `SynthesisContext.PreviousRequests` |
| Prior user/assistant audio context | Unified Realtime with `providerData.tts.conversational = true` |
| Voice design and saving | `Voices.DesignVoiceAsync`, then `Voices.PublishVoiceAsync` |
| Voice cloning | `Voices.CloneVoiceAsync`, then synthesize with the returned voice ID |
| One-shot audio | `TextToSpeech.SynthesizeSpeechAsync` |
| HTTP audio streaming | `TextToSpeech.SynthesizeSpeechStreamAsync` |
| Bidirectional TTS/STT | Existing `InworldTextToSpeechStreamRealtimeClient` / `InworldSpeechToTextStreamRealtimeClient` |
| Unified speech-to-speech, voice profiles, tools, routing, memory, backchannels | `InworldUnifiedRealtimeClient` with typed protocol events and extensible `providerData` |

The [design reference](https://docs.inworld.ai/api-reference/voiceAPI/voiceservice/design-voice)
exposes `designPrompt`, `designPromptMode`, `previewText`, language, and sample count.
It does not document a design stability parameter. Use synthesis `deliveryMode` for the
announced expressiveness presets; `CREATIVE` corresponds to the most expressive preset.
TTS-2 Flash does not support steering. Supported languages and model behavior are server capabilities,
not client-side guarantees of voice quality or latency.

## HTTP streaming

```csharp
using Inworld;

using var client = new InworldClient(apiKey);
await foreach (var message in client.TextToSpeech.SynthesizeSpeechStreamAsync(
    new SynthesizeSpeechRequest
    {
        Text = "Hey [laugh], welcome back. ¿Cómo estás? お疲れさま。",
        VoiceId = "Sarah",
        ModelId = InworldTtsModels.RealtimeTts2,
        Instruction = "Warm, relaxed, as if greeting an old friend.",
        DeliveryMode = DeliveryMode.Creative,
        AudioConfig = new AudioConfig
        {
            AudioEncoding = AudioEncoding.Pcm,
            SampleRateHertz = 24000,
        },
        TimestampType = TimestampType.Word,
    }, cancellationToken: cancellationToken))
{
    if (message.Error is { } error)
        throw new InvalidOperationException($"Synthesis failed ({error.Code}): {error.Message}");

    if (message.Result?.AudioContent is { Length: > 0 } audio)
    {
        // Consume decoded bytes here. Raw PCM is mono signed 16-bit little-endian;
        // configure your player for the requested sample rate.
    }
    // Consume Result.TimestampInfo and Result.Usage when present.
    // Keep reading to EOF: timestamps can arrive after the last audio chunk.
}
```

The reader handles NDJSON independently of HTTP read boundaries, blank lines, and
an unterminated final line. HTTP errors throw `ApiException`; in-stream errors are
returned in `Error` and must be checked. Audio bytes are already Base64-decoded.
Container framing depends on encoding; do not assume every chunk is a standalone
playable file. See the [streaming reference](https://docs.inworld.ai/api-reference/ttsAPI/texttospeech/synthesize-speech-stream).

## Unified Realtime conversation

`InworldUnifiedRealtimeClient` is generated from the unified channel in `asyncapi.yaml`.
It replaces the initial handwritten `InworldConversationClient`. Use typed `Unified*`
messages, generated `SendUnified*Async` methods, and the `UnifiedServerEvent` receive union.
The application supplies microphone capture, playback, and tool execution.

```csharp
using Inworld.Realtime;

using var conversation = new InworldUnifiedRealtimeClient(apiKey);
// Optional: refresh a backend-minted session JWT before connecting.
// conversation.TokenProvider = async ct => (await jwtCache.GetAsync(ct)).Token;
conversation.UnknownMessage += (_, args) =>
{
    // Unknown event types retain their complete raw text and parsed JSON.
    // Inspect args.RawText or args.Json; receiving continues afterwards.
};
await conversation.ConnectSessionAsync(Guid.NewGuid().ToString("N"), cancellationToken: cancellationToken);

await foreach (var update in conversation.ReceiveUpdatesAsync(cancellationToken))
{
    if (update.SessionCreated is not null)
    {
        await conversation.SendUnifiedSessionUpdateAsync(new UnifiedSessionUpdate
        {
            Session = new UnifiedSession
            {
                Type = "realtime",
                Model = "openai/gpt-4o-mini",
                Instructions = "Be warm and concise. Use [speak softly] or [laugh] when appropriate.",
                OutputModalities = ["audio", "text"],
                Audio = new UnifiedSessionAudio
                {
                    Input = new UnifiedSessionAudioInput
                    {
                        Transcription = new UnifiedSessionAudioInputTranscription
                        {
                            Model = "inworld/inworld-stt-1",
                        },
                        TurnDetection = new UnifiedTurnDetection
                        {
                            Type = "semantic_vad", CreateResponse = true,
                        },
                    },
                    Output = new UnifiedSessionAudioOutput
                    {
                        Model = "inworld-tts-2", Voice = "Sarah",
                    },
                },
                ProviderData = new UnifiedProviderData
                {
                    Stt = new UnifiedSttProviderData { VoiceProfile = true },
                    Tts = new UnifiedTtsProviderData
                    {
                        Conversational = true,
                        UserTurnMode = "both",
                        DeliveryMode = "CREATIVE",
                        SegmenterStrategy = "full_turn",
                        SteeringHandling = "emit_once",
                    },
                },
            },
        }, cancellationToken);
    }
    else if (update.SessionUpdated is not null)
    {
        // Begin sending microphone chunks from a separate producer task.
        // Serialize sends from your producer tasks: one active send and one receive
        // are supported per WebSocket connection.
        // await conversation.SendUnifiedInputAudioBufferAppendAsync(
        //     new UnifiedInputAudioBufferAppend { Audio = pcmBytes }, cancellationToken);
    }
    else if (update.ResponseOutputAudioDelta is { } audio)
    {
        var pcm = audio.Delta; // Already Base64-decoded; default PCM16, 24 kHz mono.
        // Queue pcm for playback and inspect audio.TimestampInfo if requested.
    }
    else if (update.ConversationItemInputAudioTranscriptionCompleted is { } transcript)
    {
        var emotion = transcript.ProviderData?.VoiceProfile?.Emotion;
        // Optional speaker classifications contain labels and confidence scores.
    }
    else if (update.ResponseFunctionCallArgumentsDone is { } toolCall)
    {
        // Execute toolCall.Name with toolCall.Arguments and return a typed
        // UnifiedConversationItemCreate with a function_call_output item.
    }
    else if (update.Error is { } error)
    {
        // Inspect error.Error and decide whether to stop or recover.
    }
}
```

Current `response.output_audio.*` and legacy `response.audio.*` event names have separate
typed variants. Handle the variants used by your protocol version. Generated events also
cover response creation/completion, text/transcripts, conversation items, interruption,
tool arguments, speech detection, backchannels, turn suggestions, and rate limits.

Every unified object exposes `AdditionalProperties` for unknown fields, including nested
session/audio settings and `providerData` branches. When adding arbitrary values, use
`JsonElement` values (for example `JsonSerializer.SerializeToElement(...)` with appropriate
source-generated metadata, or `JsonDocument.Parse(...).RootElement.Clone()`) so the payload
remains compatible with trimming. The `MessageReceived` event also exposes raw JSON for
known events; `UnknownMessage` retains unrecognized event types without ending reception.

Conversational mode is off by default. Set it on the first session update: changes to
`conversational` and `user_turn_mode` later are ignored by the server. It keeps user and
assistant turns in one audio context and forces full-turn segmentation, with a latency/cost
trade-off. STT voice profiling emits separate structured speaker signals.

Read [the protocol reference](https://docs.inworld.ai/api-reference/realtimeAPI/realtime/realtime-websocket)
for event shapes and [providerData](https://docs.inworld.ai/realtime/provider-data) for extensions.
Call `ConnectSessionAsync` before sending or receiving; it adds the required session query
and chooses Basic API-key or Bearer session-JWT authentication. Use one receive loop and
serialize sends. Automatic reconnection is disabled by default; application code is
responsible for restoring state if it chooses to reconnect.
