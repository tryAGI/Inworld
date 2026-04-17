# CLAUDE.md — Inworld SDK

## Overview

Auto-generated C# SDK for [Inworld AI](https://inworld.ai/) — a realtime voice and AI platform. Covers:

- **REST**: TTS synthesis, STT transcription, voice management (list/get/clone/design/publish/update/delete), LLM model discovery.
- **Realtime (WebSocket)**: bidirectional TTS streaming (`/tts/v1/voice:streamBidirectional`) and STT streaming (`/stt/v1/transcribe:streamBidirectional`).
- **MEAI**: `Microsoft.Extensions.AI.ISpeechToTextClient` implementation wired to REST (non-streaming) and WebSocket (streaming) + AIFunction tools.
- **JWT auth helper**: `InworldJwt.GenerateAsync(key, secret)` mints short-lived tokens via Inworld's IW1-HMAC-SHA256 token-exchange endpoint for client-side (Blazor, browser, mobile) use.
- **tryAGI.OpenAI**: Inworld's OpenAI-compatible chat completions (`/v1/chat/completions`) are exposed as `CustomProviders.Inworld(...)`.

**Excluded** (for now): Inworld Realtime (OpenAI-Realtime-compatible `/api/v1/realtime/session`), Router long-running management endpoints, REST streaming TTS (`/tts/v1/voice:stream`). The WebSocket TTS channel supersedes the REST streaming path.

## Build & Test

```bash
dotnet build Inworld.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Two flavours, both on the `Authorization` header:

- **Server-side (Basic, long-lived):** the Portal-issued key is already Base64-encoded.

  ```csharp
  var client = new InworldClient(apiKey); // INWORLD_API_KEY env var
  ```

- **Client-side (Bearer JWT, short-lived):** mint a JWT on a trusted backend and hand it to the client.

  ```csharp
  // Backend (server with key+secret)
  var token = await InworldJwt.GenerateAsync(
      apiKey: jwtKey,
      apiSecret: jwtSecret,
      resources: new[] { "workspaces/my-workspace" });

  // Client (Blazor WebAssembly etc.)
  var client = new InworldClient(token.Token);
  ```

The generated code emits `Authorization: Bearer <value>`. The `PrepareRequest` hook on each sub-client inspects the token:

- Starts with `eyJ`? It's a JWT — leave the Bearer scheme.
- Otherwise? Rewrite to `Authorization: Basic <value>`.

See `Extensions/InworldClient.Auth.cs` and `Extensions/InworldRealtimeClient.Auth.cs`.

## Spec Sources

Inworld has **no public OpenAPI or AsyncAPI specs**. Both are **handcrafted** from the published docs and maintained in this repo:

- `src/libs/Inworld/openapi.yaml` — 10 REST endpoints (TTS, STT, Voices, Models)
- `src/libs/Inworld/asyncapi.yaml` — two WebSocket channels (TTS bidirectional, STT bidirectional)

When Inworld updates the docs, update these files by hand and re-run `./generate.sh`.

## Multi-Spec Architecture

| Spec | Namespace | Client(s) | Purpose |
|------|-----------|-----------|---------|
| OpenAPI (`openapi.yaml`) | `Inworld` | `InworldClient` + tag sub-clients (`TextToSpeech`, `SpeechToText`, `Voices`, `Models`) | REST API |
| AsyncAPI (`asyncapi.yaml`) | `Inworld.Realtime` | `InworldTextToSpeechStreamRealtimeClient`, `InworldSpeechToTextStreamRealtimeClient` | WebSocket API |

## Key Files

- `src/libs/Inworld/openapi.yaml` — Handcrafted OpenAPI spec
- `src/libs/Inworld/asyncapi.yaml` — Handcrafted AsyncAPI spec
- `src/libs/Inworld/generate.sh` — Regen script (runs `autosdk` on both specs)
- `src/libs/Inworld/Generated/` — **Never edit** — auto-generated code
- `src/libs/Inworld/Extensions/InworldClient.Auth.cs` — REST auth rewrite Bearer → Basic (JWT auto-detected by `eyJ` prefix)
- `src/libs/Inworld/Extensions/InworldRealtimeClient.Auth.cs` — WebSocket auth rewrite Bearer → Basic
- `src/libs/Inworld/Extensions/InworldJwt.cs` — IW1-HMAC-SHA256 signing + token exchange
- `src/libs/Inworld/Extensions/InworldClient.SpeechToTextClient.cs` — MEAI `ISpeechToTextClient` (REST + WebSocket)
- `src/libs/Inworld/Extensions/InworldClient.Tools.cs` — MEAI `AIFunction` tool extensions
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## REST API Surface

| Tag | Method | Path | Description |
|-----|--------|------|-------------|
| TextToSpeech | POST | `/tts/v1/voice` | Synthesize speech |
| Voices | GET | `/voices/v1/voices` | List voices |
| Voices | GET | `/voices/v1/voices/{voiceId}` | Get voice |
| Voices | PATCH | `/voices/v1/voices/{voiceId}` | Update voice metadata |
| Voices | DELETE | `/voices/v1/voices/{voiceId}` | Delete voice |
| Voices | POST | `/voices/v1/voices:clone` | Instant Voice Clone |
| Voices | POST | `/voices/v1/voices:design` | Voice design from prompt |
| Voices | POST | `/voices/v1/voices/{voiceId}:publish` | Publish designed voice |
| SpeechToText | POST | `/stt/v1/transcribe` | Transcribe audio |
| Models | GET | `/llm/v1alpha/models` | List LLM models |

## WebSocket (Realtime) API Surface

### TextToSpeech (`/tts/v1/voice:streamBidirectional`)
- Client → server: `TtsCreateContext`, `TtsSendText`, `TtsFlushContext`, `TtsCloseContext`
- Server → client: `TtsContextCreated`, `TtsAudioChunk`, `TtsFlushCompleted`, `TtsContextClosed`
- Limits: 20 concurrent connections, 5 contexts/connection, 10-min inactivity timeout, 1,000-char text chunks

### SpeechToText (`/stt/v1/transcribe:streamBidirectional`)
- Client → server: `SttConfigure` (must be first), `SttAudioChunk`, `SttEndTurn`, `SttCloseStream`
- Server → client: `SttTranscription`, `SttUsage`, `SttSpeechStarted`

## MEAI Integration

| Interface | Implementation | Notes |
|-----------|----------------|-------|
| `ISpeechToTextClient` | `InworldClient` | REST transcribe for `GetTextAsync`; WebSocket stream for `GetStreamingTextAsync` |
| `IChatClient` | *(not applicable)* | Use `CustomProviders.Inworld(key)` from `tryAGI.OpenAI` instead |
| `IEmbeddingGenerator` | *(not applicable)* | Inworld does not expose embeddings |
| AIFunction tools | `AsSynthesizeSpeechTool`, `AsListVoicesTool`, `AsListModelsTool`, `AsDesignVoiceTool` | Attach to any `IChatClient` |

## NuGet

- **PackageId:** `tryAGI.Inworld`

## Known Gotchas

- **Security resolver matches Http auth by Name.** Do NOT rewrite the stored `EndPointAuthorization.Name` — the resolver drops the auth if the name no longer matches the operation's requirement. Rewrite on the outgoing `HttpRequestMessage` instead (see `InworldClient.Auth.cs`).
- **IW1-HMAC-SHA256 signing**: the signature uses `api-engine.inworld.ai` as the host even though the request goes to `api.inworld.ai`. The "method" in the signature is the gRPC service name (`ai.inworld.engine.WorldEngine/GenerateToken`), not the HTTP path.
- **AsyncAPI discriminator**: Inworld's realtime messages use the top-level JSON key (`create`, `send_text`, ...) as the discriminator, not a `type` field. The spec models each message shape separately; autosdk generates one `Send*Async` method per message type.
- **REST `SpeechToText` vs MEAI `ISpeechToTextClient`**: the generated tag-grouped sub-client is `SpeechToTextClient` (accessible via `client.SpeechToText.*`). The MEAI interface is implemented on the main `InworldClient` class using a `Meai = Microsoft.Extensions.AI` namespace alias to avoid the ambiguity with generated `Inworld.ISpeechToTextClient`.
