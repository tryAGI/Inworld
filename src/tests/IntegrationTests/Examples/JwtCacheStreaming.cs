/*
order: 80
title: JwtCache + Streaming STT
slug: jwt-cache-streaming

Wire an `InworldJwtCache` into `InworldClient` so the realtime (WebSocket)
streaming path pulls a fresh JWT from the cache on every connect. This
keeps long-lived backends correct across token rotations without
reconstructing the client.
*/

#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using Meai = Microsoft.Extensions.AI;

namespace Inworld.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(60_000)]
    public async Task Example_JwtCache_WiredIntoStreaming()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("INWORLD_JWT_KEY") is { Length: > 0 } k ? k :
            DecodeKeyPair(Environment.GetEnvironmentVariable("INWORLD_API_KEY")).key;
        var apiSecret =
            Environment.GetEnvironmentVariable("INWORLD_JWT_SECRET") is { Length: > 0 } s ? s :
            DecodeKeyPair(Environment.GetEnvironmentVariable("INWORLD_API_KEY")).secret;

        if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(apiSecret))
        {
            throw new AssertInconclusiveException("INWORLD_API_KEY (or INWORLD_JWT_KEY + INWORLD_JWT_SECRET) is required.");
        }

        //// Build a JwtCache once — in production it would be a singleton.
        using var jwtCache = new InworldJwtCache(apiKey, apiSecret);

        //// Construct InworldClient directly from the cache: REST uses the
        //// token active at construction, streaming fetches a fresh JWT per
        //// connect via RealtimeTokenProvider.
        using var client = new InworldClient(jwtCache);

        //// Prove the provider hook is wired up.
        client.RealtimeTokenProvider.Should().NotBeNull();
        var preview = await client.RealtimeTokenProvider!(CancellationToken.None);
        preview.Should().StartWith("eyJ");

        //// Synthesize a short phrase so we have something for STT to hear.
        const string phrase = "JWT cache is wired into streaming.";
        var tts = await client.TextToSpeech.SynthesizeSpeechAsync(
            text: phrase,
            voiceId: "Dennis",
            modelId: "inworld-tts-1.5-max",
            audioConfig: new AudioConfig
            {
                AudioEncoding = AudioEncoding.Linear16,
                SampleRateHertz = 16000,
            });

        var audio = StripWavHeader(tts.AudioContent!);

        //// Stream it back through MEAI. The WebSocket connect pulls a fresh
        //// token from the cache under the hood.
        Meai.ISpeechToTextClient speech = client;
        using var audioStream = new MemoryStream(audio);

        var transcriptBuilder = new System.Text.StringBuilder();
        await foreach (var update in speech.GetStreamingTextAsync(
            audioStream,
            new Meai.SpeechToTextOptions
            {
                ModelId = "assemblyai/universal-streaming-multilingual",
                SpeechLanguage = "en-US",
            },
            CancellationToken.None))
        {
            if (update.Kind == Meai.SpeechToTextResponseUpdateKind.TextUpdated)
            {
                transcriptBuilder.Append(update.Text);
            }

            if (update.Kind == Meai.SpeechToTextResponseUpdateKind.SessionClose)
            {
                break;
            }
        }

        transcriptBuilder.ToString().Should().NotBeNullOrWhiteSpace(
            because: "streaming STT via JwtCache-backed auth should still return a transcript");
    }
}
