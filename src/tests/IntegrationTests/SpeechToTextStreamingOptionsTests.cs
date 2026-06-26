#nullable enable
#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using System.Reflection;
using Meai = Microsoft.Extensions.AI;

namespace Inworld.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void SpeechToTextStreamingOptions_MapToRealtimeTranscribeConfig()
    {
        var options = new Meai.SpeechToTextOptions
        {
            ModelId = InworldClient.SonioxSttRealtimeV5ModelId,
            SpeechLanguage = "ru-RU",
            AdditionalProperties = new Meai.AdditionalPropertiesDictionary
            {
                [InworldSpeechToTextPropertyNames.AudioEncoding] = "MULAW",
                [InworldSpeechToTextPropertyNames.SampleRateHertz] = 8000,
                [InworldSpeechToTextPropertyNames.NumberOfChannels] = 2,
                [InworldSpeechToTextPropertyNames.InactivityTimeoutSeconds] = 15,
                [InworldSpeechToTextPropertyNames.EndOfTurnConfidenceThreshold] = 0.65,
                [InworldSpeechToTextPropertyNames.Prompts] = new[] { "Advantage", "tryAGI" },
                [InworldSpeechToTextPropertyNames.IncludeWordTimestamps] = true,
                [InworldSpeechToTextPropertyNames.EnableVoiceProfile] = true,
            },
        };

        var config = CreateStreamingTranscribeConfigForTest(options);

        config.ModelId.Should().Be(InworldClient.SonioxSttRealtimeV5ModelId);
        config.Language.Should().Be("ru-RU");
        config.AudioEncoding.Should().Be("MULAW");
        config.SampleRateHertz.Should().Be(8000);
        config.NumberOfChannels.Should().Be(2);
        config.InactivityTimeoutSeconds.Should().Be(15);
        config.EndOfTurnConfidenceThreshold.Should().BeApproximately(0.65F, 0.0001F);
        config.Prompts.Should().Equal("Advantage", "tryAGI");
        config.IncludeWordTimestamps.Should().BeTrue();
        config.VoiceProfileConfig.Should().NotBeNull();
        config.VoiceProfileConfig!.EnableVoiceProfile.Should().BeTrue();
    }

    private static Realtime.SttTranscribeConfigParams CreateStreamingTranscribeConfigForTest(
        Meai.SpeechToTextOptions options)
    {
        var method = typeof(InworldClient).GetMethod(
            "CreateStreamingTranscribeConfig",
            BindingFlags.NonPublic | BindingFlags.Static);

        method.Should().NotBeNull();
        var config = method!.Invoke(null, new object?[] { options }) as Realtime.SttTranscribeConfigParams;
        config.Should().NotBeNull();
        return config!;
    }
}
