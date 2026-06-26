namespace Inworld.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void SpeechToTextModelIds_ExposeCurrentRoutedProviders()
    {
        InworldClient.CurrentInworldSttModelId.Should().Be("inworld/inworld-stt-1");
        InworldClient.DeepgramFluxGeneralEnglishSttModelId.Should().Be("deepgram/flux-general-en");
        InworldClient.DeepgramFluxGeneralMultilingualSttModelId.Should().Be("deepgram/flux-general-multi");
        InworldClient.SonioxSttRealtimeV5ModelId.Should().Be("soniox/stt-rt-v5");
    }
}
