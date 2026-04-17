#nullable enable
#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using Meai = Microsoft.Extensions.AI;

namespace Inworld.IntegrationTests;

/// <summary>
/// Reusable conformance test pack for any
/// <see cref="Meai.ISpeechToTextClient"/> implementation. Derived test
/// classes need only wire up <see cref="CreateClient"/> and
/// <see cref="GenerateTestAudioAsync"/> — every other test comes for free.
/// <para>
/// The goal is to catch behavioural regressions that a generic MEAI
/// consumer would notice: the metadata service contract, the streaming
/// lifecycle (SessionOpen → text updates → SessionClose), reasonable
/// transcript accuracy, and graceful cancellation.
/// </para>
/// </summary>
public abstract class MeaiSpeechToTextConformanceTests
{
    /// <summary>Provider name expected from <see cref="Meai.SpeechToTextClientMetadata.ProviderName"/>.</summary>
    protected abstract string ExpectedProviderName { get; }

    /// <summary>Phrase to synthesize for round-trip tests.</summary>
    protected virtual string TestPhrase => "Testing the conformance suite.";

    /// <summary>
    /// Case-insensitive substring the round-trip transcript must contain.
    /// Defaults to a distinctive word from <see cref="TestPhrase"/> that TTS
    /// and STT are unlikely to hallucinate around.
    /// </summary>
    protected virtual string TranscriptMustContain => "conformance";

    /// <summary>Options to hand to the streaming call.</summary>
    protected virtual Meai.SpeechToTextOptions? StreamingOptions { get; } = null;

    /// <summary>Create a fresh client for each test. May throw <see cref="AssertInconclusiveException"/> when prerequisites are missing.</summary>
    protected abstract Meai.ISpeechToTextClient CreateClient();

    /// <summary>
    /// Produce audio bytes suitable for the streaming path (typically 16 kHz
    /// LINEAR16 PCM). Implementations can synthesize TTS on the fly or
    /// return a bundled fixture.
    /// </summary>
    protected abstract Task<byte[]> GenerateTestAudioAsync(string phrase, CancellationToken cancellationToken);

    [TestMethod]
    public void Conformance_Metadata_IsPopulated()
    {
        using var client = CreateClient() as IDisposable;
        var speech = (Meai.ISpeechToTextClient)client!;

        var metadata = speech.GetService(typeof(Meai.SpeechToTextClientMetadata))
            as Meai.SpeechToTextClientMetadata;

        metadata.Should().NotBeNull(because: "ISpeechToTextClient must expose SpeechToTextClientMetadata via GetService");
        metadata!.ProviderName.Should().Be(ExpectedProviderName);
    }

    [TestMethod]
    public void Conformance_GetService_ReturnsSelfForAssignableType()
    {
        using var client = CreateClient() as IDisposable;
        var speech = (Meai.ISpeechToTextClient)client!;

        speech.GetService(speech.GetType()).Should().BeSameAs(speech);
        speech.GetService(typeof(Meai.ISpeechToTextClient)).Should().BeSameAs(speech);
    }

    [TestMethod]
    public void Conformance_GetService_ReturnsNullForUnknownKeyedService()
    {
        using var client = CreateClient() as IDisposable;
        var speech = (Meai.ISpeechToTextClient)client!;

        speech.GetService(typeof(Meai.SpeechToTextClientMetadata), serviceKey: "anything").Should().BeNull();
    }

    [TestMethod]
    [Timeout(60_000)]
    public async Task Conformance_GetStreamingTextAsync_EmitsSessionOpenAndClose()
    {
        using var client = CreateClient() as IDisposable;
        var speech = (Meai.ISpeechToTextClient)client!;

        var audio = await GenerateTestAudioAsync(TestPhrase, CancellationToken.None);
        using var audioStream = new MemoryStream(audio);

        var kinds = new List<Meai.SpeechToTextResponseUpdateKind>();
        await foreach (var update in speech.GetStreamingTextAsync(audioStream, StreamingOptions, CancellationToken.None))
        {
            kinds.Add(update.Kind);
            if (update.Kind == Meai.SpeechToTextResponseUpdateKind.SessionClose)
            {
                break;
            }
        }

        kinds.Should().NotBeEmpty();
        kinds.First().Should().Be(Meai.SpeechToTextResponseUpdateKind.SessionOpen,
            because: "streaming clients must open the session as the first update");
        kinds.Last().Should().Be(Meai.SpeechToTextResponseUpdateKind.SessionClose,
            because: "streaming clients must close the session as the final update");
    }

    [TestMethod]
    [Timeout(60_000)]
    public async Task Conformance_GetStreamingTextAsync_ProducesFinalTranscript()
    {
        using var client = CreateClient() as IDisposable;
        var speech = (Meai.ISpeechToTextClient)client!;

        var audio = await GenerateTestAudioAsync(TestPhrase, CancellationToken.None);
        using var audioStream = new MemoryStream(audio);

        var finalText = new System.Text.StringBuilder();
        await foreach (var update in speech.GetStreamingTextAsync(audioStream, StreamingOptions, CancellationToken.None))
        {
            if (update.Kind == Meai.SpeechToTextResponseUpdateKind.TextUpdated)
            {
                finalText.Append(update.Text);
            }

            if (update.Kind == Meai.SpeechToTextResponseUpdateKind.SessionClose)
            {
                break;
            }
        }

        finalText.ToString().Should().NotBeNullOrWhiteSpace(
            because: "a finalized TextUpdated should land before the session closes");

        finalText.ToString().ToLowerInvariant().Should().Contain(TranscriptMustContain.ToLowerInvariant(),
            because: "the round-trip transcript should overlap a distinctive word from the synthesized phrase");
    }

    [TestMethod]
    [Timeout(60_000)]
    public async Task Conformance_GetStreamingTextAsync_HonorsCancellation()
    {
        using var client = CreateClient() as IDisposable;
        var speech = (Meai.ISpeechToTextClient)client!;

        var audio = await GenerateTestAudioAsync(TestPhrase, CancellationToken.None);
        using var audioStream = new MemoryStream(audio);

        using var cts = new CancellationTokenSource();

        var task = Task.Run(async () =>
        {
            try
            {
                await foreach (var _ in speech.GetStreamingTextAsync(audioStream, StreamingOptions, cts.Token))
                {
                    // drain — we'll cancel mid-drain
                }
            }
            catch (OperationCanceledException)
            {
                // expected
            }
        });

        // Cancel almost immediately — the enumerator should stop producing.
        cts.CancelAfter(TimeSpan.FromMilliseconds(50));

        await task.WaitAsync(TimeSpan.FromSeconds(30));

        task.IsCompletedSuccessfully.Should().BeTrue(
            because: "cancellation should terminate the stream without surfacing to the caller beyond OperationCanceledException");
    }
}

/// <summary>
/// Concrete conformance suite exercising <see cref="InworldClient"/>.
/// Future providers can mirror this class to opt into the same coverage.
/// </summary>
[TestClass]
public sealed class InworldMeaiSpeechToTextConformanceTests : MeaiSpeechToTextConformanceTests
{
    protected override string ExpectedProviderName => "inworld";

    protected override Meai.SpeechToTextOptions? StreamingOptions { get; } = new()
    {
        ModelId = "inworld/inworld-stt-1",
        SpeechLanguage = "en-US",
    };

    protected override Meai.ISpeechToTextClient CreateClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("INWORLD_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("INWORLD_API_KEY environment variable is not found.");

        return new InworldClient(apiKey);
    }

    protected override async Task<byte[]> GenerateTestAudioAsync(string phrase, CancellationToken cancellationToken)
    {
        using var client = new InworldClient(
            Environment.GetEnvironmentVariable("INWORLD_API_KEY")
            ?? throw new AssertInconclusiveException("INWORLD_API_KEY environment variable is not found."));

        var tts = await client.TextToSpeech.SynthesizeSpeechAsync(
            text: phrase,
            voiceId: "Dennis",
            modelId: "inworld-tts-1.5-max",
            audioConfig: new AudioConfig
            {
                AudioEncoding = AudioEncoding.Linear16,
                SampleRateHertz = 16000,
            },
            cancellationToken: cancellationToken);

        var audio = tts.AudioContent!;
        if (audio.Length > 44 &&
            audio[0] == (byte)'R' && audio[1] == (byte)'I' && audio[2] == (byte)'F' && audio[3] == (byte)'F')
        {
            var pcm = new byte[audio.Length - 44];
            Array.Copy(audio, 44, pcm, 0, pcm.Length);
            return pcm;
        }

        return audio;
    }
}
