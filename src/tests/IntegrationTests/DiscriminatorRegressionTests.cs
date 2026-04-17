#nullable enable
#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using Meai = Microsoft.Extensions.AI;

namespace Inworld.IntegrationTests;

/// <summary>
/// Regression coverage for the hand-rolled server-event parser that
/// <see cref="InworldClient"/> uses in place of the AutoSDK-generated
/// discriminated union (which only scores top-level properties and
/// mis-classifies every Inworld frame — tracked in
/// <see href="https://github.com/tryAGI/AutoSDK/issues/281"/>).
/// <para>
/// These are offline snapshot tests — no network required.
/// </para>
/// </summary>
[TestClass]
public sealed class DiscriminatorRegressionTests
{
    [TestMethod]
    public void InterimTranscription_ProducesTextUpdating()
    {
        const string json = """
            {"result":{"transcription":{"transcript":"Hello","isFinal":false,"wordTimestamps":[]}}}
            """;

        var (update, endOfStream) = InworldClient.ParseServerFrame(json, "resp-1");

        endOfStream.Should().BeFalse();
        update.Should().NotBeNull();
        update!.Kind.Should().Be(Meai.SpeechToTextResponseUpdateKind.TextUpdating);
        update.Text.Should().Be("Hello");
        update.ResponseId.Should().Be("resp-1");
    }

    [TestMethod]
    public void FinalTranscription_ProducesTextUpdated()
    {
        const string json = """
            {"result":{"transcription":{"transcript":"Hello world.","isFinal":true,"wordTimestamps":[]}}}
            """;

        var (update, endOfStream) = InworldClient.ParseServerFrame(json, "resp-1");

        endOfStream.Should().BeFalse();
        update.Should().NotBeNull();
        update!.Kind.Should().Be(Meai.SpeechToTextResponseUpdateKind.TextUpdated);
        update.Text.Should().Be("Hello world.");
    }

    [TestMethod]
    public void SpeechStarted_ProducesTextUpdatingWithStartTime()
    {
        const string json = """
            {"result":{"speechStarted":{"startTimeMs":120,"confidence":0.7}}}
            """;

        var (update, endOfStream) = InworldClient.ParseServerFrame(json, "resp-1");

        endOfStream.Should().BeFalse();
        update.Should().NotBeNull();
        update!.Kind.Should().Be(Meai.SpeechToTextResponseUpdateKind.TextUpdating);
        update.StartTime.Should().Be(TimeSpan.FromMilliseconds(120));
    }

    [TestMethod]
    public void Usage_SignalsEndOfStream()
    {
        const string json = """
            {"result":{"usage":{"transcribedAudioMs":3000,"modelId":"inworld/inworld-stt-1"}}}
            """;

        var (update, endOfStream) = InworldClient.ParseServerFrame(json, "resp-1");

        endOfStream.Should().BeTrue();
        update.Should().BeNull(because: "usage frames have no user-visible transcript");
    }

    [TestMethod]
    public void UnknownFrameShape_IsSkipped()
    {
        const string json = """
            {"result":{"somethingNewInworldAdded":{"foo":"bar"}}}
            """;

        var (update, endOfStream) = InworldClient.ParseServerFrame(json, "resp-1");

        update.Should().BeNull();
        endOfStream.Should().BeFalse();
    }

    [TestMethod]
    public void FrameWithoutResultEnvelope_IsSkipped()
    {
        const string json = """
            {"error":{"code":3,"message":"No STT client found for model: inworld/stt-v1"}}
            """;

        var (update, endOfStream) = InworldClient.ParseServerFrame(json, "resp-1");

        update.Should().BeNull();
        endOfStream.Should().BeFalse();
    }
}
