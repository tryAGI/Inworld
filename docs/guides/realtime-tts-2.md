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
| Unified speech-to-speech, voice profiles, tools, routing, memory, backchannels | `InworldConversationClient` with JSON protocol events and `providerData` |

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

`InworldConversationClient` uses JSON objects so callers can use the complete protocol,
including provider extensions and new event fields. It is a WebSocket transport;
applications supply microphone capture, playback, and tool execution. It does not
implement WebRTC or automatically execute tools.

```csharp
using System.Text.Json.Nodes;
using Inworld.Realtime;

using var conversation = new InworldConversationClient(apiKey);
// For a backend-minted session JWT refreshed at connect time:
// conversation.TokenProvider = async ct => (await jwtCache.GetAsync(ct)).Token;
await conversation.ConnectAsync(Guid.NewGuid().ToString("N"), cancellationToken: cancellationToken);

await foreach (var update in conversation.ReceiveUpdatesAsync(cancellationToken: cancellationToken))
{
    switch (update["type"]?.GetValue<string>())
    {
        case "session.created":
            await conversation.SendAsync(JsonNode.Parse("""
                {
                  "type": "session.update",
                  "session": {
                    "type": "realtime",
                    "model": "openai/gpt-4o-mini",
                    "instructions": "Be warm and concise. Use [speak softly] or [laugh] when appropriate.",
                    "output_modalities": ["audio", "text"],
                    "audio": {
                      "input": {
                        "transcription": { "model": "inworld/inworld-stt-1" },
                        "turn_detection": { "type": "semantic_vad", "create_response": true }
                      },
                      "output": { "model": "inworld-tts-2", "voice": "Sarah" }
                    },
                    "providerData": {
                      "stt": { "voice_profile": true },
                      "tts": {
                        "conversational": true,
                        "user_turn_mode": "both",
                        "delivery_mode": "CREATIVE",
                        "segmenter_strategy": "full_turn",
                        "steering_handling": "emit_once"
                      },
                      "backchannel": { "enabled": true },
                      "responsiveness": { "enabled": true }
                    }
                  }
                }
                """)!.AsObject(), cancellationToken);
            break;
        case "session.updated":
            // Begin sending microphone chunks from a separate producer task.
            break;
        case "response.audio.delta":
        case "response.output_audio.delta":
            var pcm = Convert.FromBase64String(update["delta"]!.GetValue<string>());
            // Queue pcm for playback (default PCM16, 24 kHz mono).
            break;
        case "error":
            // Inspect update["error"] and decide whether to stop or recover.
            break;
    }
}
```

Send microphone audio with `SendAsync(new JsonObject { ["type"] = "input_audio_buffer.append",
["audio"] = Convert.ToBase64String(pcmBytes) }, cancellationToken)`.
The same method accepts conversation text/history, `response.create`, interruption/cancellation,
function outputs, and partial session updates. Receive events retain transcripts, voice profiles,
tool arguments, routing metadata, and usage. Handle both audio delta spellings when integrating
across protocol versions. Read [the protocol reference](https://docs.inworld.ai/api-reference/realtimeAPI/realtime/realtime-websocket)
for event shapes and [providerData](https://docs.inworld.ai/realtime/provider-data) for extensions.

Conversational mode is off by default. Set it on the first session update: changes to
`conversational` and `user_turn_mode` later are ignored by the server. It keeps user and
assistant turns in one audio context and forces full-turn segmentation, with a latency/cost
trade-off. STT voice profiling emits separate structured speaker signals. Backchannels and
responsiveness are optional.

Use one receive loop per connection. Concurrent sends are serialized; events are never retried
or replayed automatically. A normal WebSocket close ends enumeration; malformed/oversized messages
and abnormal closes throw. Cancel and await producer/receiver tasks before disposing the client.
API keys are sent as Basic credentials without re-encoding; session JWTs use Bearer.
