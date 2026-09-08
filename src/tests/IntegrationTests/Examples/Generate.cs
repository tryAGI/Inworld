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

        //// TTS-2 supports BCP-47 languages, natural-language direction, conversation context, and enhanced denoising.
        //// Use InworldTtsModels.RealtimeTts2Flash instead when minimum latency and cost matter most.
        var response = await client.TextToSpeech.SynthesizeSpeechAsync(
            text: "Your booking reference is <verbatim>AHAA7771Z</verbatim>.",
            voiceId: "Dennis",
            modelId: InworldTtsModels.RealtimeTts2,
            deliveryMode: DeliveryMode.Balanced,
            language: "en-US",
            instruction: "Speak warmly and clearly, emphasizing the booking reference.",
            enhanceGeneration: true,
            synthesisContext: new SynthesisContext
            {
                PreviousRequests =
                [
                    new PreviousSynthesisRequest { Text = "I found your reservation." },
                ],
            });

        //// The response contains Base64-encoded audio bytes ready to decode into a playable file.
        response.Should().NotBeNull();
        response.AudioContent.Should().NotBeNullOrEmpty();
    }
}
