#nullable enable

using System.Text.Json.Nodes;
using Inworld.Realtime;

namespace Inworld.IntegrationTests;

/// <summary>Offline contract coverage for the Realtime TTS-2 GA family.</summary>
[TestClass]
public sealed class Tts2GaContractTests
{
    [TestMethod]
    public void ModelIds_ExposeBothGaModels()
    {
        InworldTtsModels.RealtimeTts2.Should().Be("inworld-tts-2");
        InworldTtsModels.RealtimeTts2Flash.Should().Be("inworld-tts-2-flash");
    }

    [TestMethod]
    public void AiTool_AdvertisesGaControls()
    {
        using var client = new InworldClient("test-key");
        var schema = JsonNode.Parse(client.AsSynthesizeSpeechTool().JsonSchema.GetRawText())!.AsObject();
        var properties = schema["properties"]!.AsObject();

        properties.ContainsKey("modelId").Should().BeTrue();
        properties.ContainsKey("language").Should().BeTrue();
        properties.ContainsKey("instruction").Should().BeTrue();
        properties.ContainsKey("enhanceGeneration").Should().BeTrue();
        properties["modelId"]!["description"]!.GetValue<string>()
            .Should().Contain("inworld-tts-2-flash");
    }

    [TestMethod]
    public void RestRequest_SerializesGaControls()
    {
        var request = new SynthesizeSpeechRequest
        {
            Text = "Reference <verbatim>AZ-42</verbatim>.",
            VoiceId = "Dennis",
            ModelId = InworldTtsModels.RealtimeTts2,
            DeliveryMode = DeliveryMode.Creative,
            Language = "en-US",
            Instruction = "Speak slowly and clearly.",
            EnhanceGeneration = true,
            SynthesisContext = new SynthesisContext
            {
                PreviousRequests =
                [
                    new PreviousSynthesisRequest { Text = "I found your reservation." },
                ],
            },
        };

        var json = JsonNode.Parse(request.ToJson())!.AsObject();

        json["modelId"]!.GetValue<string>().Should().Be("inworld-tts-2");
        json["language"]!.GetValue<string>().Should().Be("en-US");
        json["instruction"]!.GetValue<string>().Should().Be("Speak slowly and clearly.");
        json["enhanceGeneration"]!.GetValue<bool>().Should().BeTrue();
        json["deliveryMode"]!.GetValue<string>().Should().Be("CREATIVE");
        json["synthesisContext"]!["previousRequests"]![0]!["text"]!
            .GetValue<string>().Should().Be("I found your reservation.");
    }

    [TestMethod]
    public void WebSocketContext_SerializesFlashAndLanguage()
    {
        var request = new TtsCreateContextParams
        {
            VoiceId = "Dennis",
            ModelId = InworldTtsModels.RealtimeTts2Flash,
            Language = "ja-JP",
            AutoMode = true,
        };

        var json = JsonNode.Parse(request.ToJson())!.AsObject();

        json["modelId"]!.GetValue<string>().Should().Be("inworld-tts-2-flash");
        json["language"]!.GetValue<string>().Should().Be("ja-JP");
        json["autoMode"]!.GetValue<bool>().Should().BeTrue();
    }

    [TestMethod]
    public void VoiceCreation_UsesExpandedLanguageCodes()
    {
        var design = new DesignVoiceRequest
        {
            DesignPrompt = "A warm Vietnamese narrator with clear articulation.",
            PreviewText = "Xin chào, tôi có thể giúp gì cho bạn?",
            LanguageCode = "vi",
            DesignPromptMode = DesignPromptMode.Assisted,
        };
        var clone = new CloneVoiceRequest
        {
            DisplayName = "Vietnamese narrator",
            VoiceSamples = [new VoiceSample { AudioData = [0] }],
            LanguageCode = "vi",
        };

        var designJson = JsonNode.Parse(design.ToJson())!.AsObject();
        var cloneJson = JsonNode.Parse(clone.ToJson())!.AsObject();

        designJson["languageCode"]!.GetValue<string>().Should().Be("vi");
        designJson["designPromptMode"]!.GetValue<string>().Should().Be("DESIGN_PROMPT_MODE_ASSISTED");
        cloneJson["languageCode"]!.GetValue<string>().Should().Be("vi");
    }
}
