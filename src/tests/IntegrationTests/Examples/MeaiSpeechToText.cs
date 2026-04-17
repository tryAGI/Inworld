/*
order: 60
title: MEAI ISpeechToTextClient
slug: meai-speech-to-text

`InworldClient` implements `Microsoft.Extensions.AI.ISpeechToTextClient` so the
same call site works with Inworld, Deepgram, or any other MEAI STT provider.

Non-streaming calls hit the REST `/stt/v1/transcribe` endpoint. Streaming
calls open a WebSocket to `/stt/v1/transcribe:streamBidirectional`.
*/

#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using Meai = Microsoft.Extensions.AI;

namespace Inworld.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_AsMeaiSpeechToTextClient()
    {
        using var client = GetAuthenticatedClient();

        //// InworldClient implements Meai.ISpeechToTextClient directly.
        Meai.ISpeechToTextClient speechClient = client;

        //// Metadata is exposed via ISpeechToTextClient.GetService.
        var metadata = speechClient.GetService(typeof(Meai.SpeechToTextClientMetadata))
            as Meai.SpeechToTextClientMetadata;

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be("inworld");
    }
}
