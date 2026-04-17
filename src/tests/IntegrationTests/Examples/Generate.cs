/*
order: 10
title: Text to Speech
slug: text-to-speech

Synthesize natural-sounding speech from text using an Inworld voice.
*/

namespace Inworld.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SynthesizeSpeech()
    {
        //// Create an Inworld client using your API key.
        using var client = GetAuthenticatedClient();

        //// Synthesize a short greeting using the Inworld TTS 1.5 Max model.
        var response = await client.TextToSpeech.SynthesizeSpeechAsync(
            text: "Hello, welcome to Inworld.",
            voiceId: "Dennis",
            modelId: "inworld-tts-1.5-max");

        //// The response contains Base64-encoded audio bytes ready to decode into a playable file.
        response.Should().NotBeNull();
        response.AudioContent.Should().NotBeNullOrEmpty();
    }
}
