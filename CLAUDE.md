# CLAUDE.md — Inworld SDK

## Overview

Auto-generated C# SDK for [Inworld AI](https://inworld.ai/) — a realtime voice and AI platform. Covers TTS synthesis, STT transcription, voice management (list, get, clone, design, publish, update, delete), and model discovery.

**Excluded from this SDK:**
- WebSocket/Realtime streaming endpoints (`/tts/v1/voice:streamBidirectional`, `/stt/v1/transcribe:streamBidirectional`, Realtime API)
- OpenAI-compatible Chat Completions (`/v1/chat/completions`) — use `tryAGI.OpenAI` with Inworld as a CustomProvider
- LLM Router long-running management endpoints

## Build & Test

```bash
dotnet build Inworld.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Inworld uses `Authorization: Basic <API_KEY>` where `<API_KEY>` is the already-Base64-encoded key from the Inworld Portal. Pass the key verbatim — do not re-encode.

```csharp
var client = new InworldClient(apiKey); // INWORLD_API_KEY env var
```

**Important:** The generated code emits `Authorization: Bearer <key>`, but Inworld expects `Authorization: Basic <key>`. The `Authorized` partial hook in `InworldClient.Auth.cs` rewrites the scheme name:

```csharp
// In Extensions/InworldClient.Auth.cs
partial void Authorized(HttpClient client)
{
    for (int i = 0; i < Authorizations.Count; i++)
    {
        var auth = Authorizations[i];
        if (auth is { Type: "Http", Name: "Bearer" })
            Authorizations[i] = new EndPointAuthorization
            { Type = auth.Type, Location = auth.Location, Name = "Basic", Value = auth.Value };
    }
}
```

## Spec Source

Inworld has **no public OpenAPI spec**. `openapi.yaml` is **handcrafted** from the published API reference:
- `https://docs.inworld.ai/llms.txt`
- `https://docs.inworld.ai/api-reference/ttsAPI/*`
- `https://docs.inworld.ai/api-reference/sttAPI/*`
- `https://docs.inworld.ai/api-reference/voiceAPI/*`
- `https://docs.inworld.ai/api-reference/modelsAPI/*`

When the upstream docs change, update `src/libs/Inworld/openapi.yaml` by hand and re-run `./generate.sh`.

## Key Files

- `src/libs/Inworld/openapi.yaml` — **Handcrafted** OpenAPI 3.0 spec
- `src/libs/Inworld/generate.sh` — Regeneration script (consumes local `openapi.yaml`)
- `src/libs/Inworld/Generated/` — **Never edit** — auto-generated code
- `src/libs/Inworld/Extensions/InworldClient.Auth.cs` — Auth scheme fix: Bearer → Basic
- `src/libs/Inworld/Extensions/InworldClient.Tools.cs` — MEAI `AIFunction` tool extensions
- `src/tests/IntegrationTests/Tests.cs` — Test helper
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## API Surface

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

Access via tag-grouped sub-clients: `client.TextToSpeech.*`, `client.Voices.*`, `client.SpeechToText.*`, `client.Models.*`.

## MEAI Integration

- **AIFunction tools:** `AsSynthesizeSpeechTool`, `AsListVoicesTool`, `AsListModelsTool`, `AsDesignVoiceTool` — available on `InworldClient`
- **`ISpeechToTextClient`:** Not implemented on the REST surface (the transcribe endpoint takes Base64 inline audio and maps awkwardly to MEAI's `Stream`-based contract). STT streaming is WebSocket-only and excluded from this SDK.
- **`IChatClient`:** Not implemented — Inworld's `/v1/chat/completions` is OpenAI-compatible; prefer `tryAGI.OpenAI` with Inworld as a CustomProvider.

## NuGet

- **PackageId:** `tryAGI.Inworld`
