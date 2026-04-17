#nullable enable
#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using Meai = Microsoft.Extensions.AI;

namespace Inworld.IntegrationTests;

/// <summary>
/// Captured real-world server-event sequence from a live Inworld streaming
/// STT session (phrase: "Hello world, this is an Inworld streaming test.").
/// <para>
/// Feeding this frame-by-frame through
/// <see cref="InworldClient.ParseServerFrame"/> should reconstruct the
/// final transcript and signal end-of-stream on the usage frame. This
/// guards against silent regressions in the hand-rolled parser — the one
/// we fall back to because the AutoSDK-generated discriminator can't
/// distinguish inner-key envelopes (tracked in
/// <see href="https://github.com/tryAGI/AutoSDK/issues/281"/>).
/// </para>
/// <para>
/// Offline — no network or API key required.
/// </para>
/// </summary>
[TestClass]
public sealed class CapturedFrameReplayTests
{
    private static readonly string[] CapturedFrames =
    {
        """{"result":{"transcription":{"transcript":"Hello","isFinal":false,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"transcription":{"transcript":"Hello world,","isFinal":false,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"transcription":{"transcript":"Hello world, this","isFinal":false,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"transcription":{"transcript":"Hello world, this is","isFinal":false,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"transcription":{"transcript":"Hello world, this is an","isFinal":false,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"transcription":{"transcript":"Hello world, this is an","isFinal":false,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"transcription":{"transcript":"Hello world, this is an","isFinal":false,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"transcription":{"transcript":"Hello world, this is an inworld","isFinal":false,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"transcription":{"transcript":"Hello world, this is an inworld","isFinal":false,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"transcription":{"transcript":"Hello world, this is an inworld streaming","isFinal":false,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"transcription":{"transcript":"Hello world, this is an inworld streaming","isFinal":false,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"transcription":{"transcript":"Hello world, this is an in - world streaming test.","isFinal":true,"wordTimestamps":[],"voiceProfile":null}}}""",
        """{"result":{"usage":{"transcribedAudioMs":3000,"modelId":"inworld/inworld-stt-1"}}}""",
    };

    [TestMethod]
    public void ReplayCapturedFrames_ReconstructsFinalTranscript()
    {
        var updates = new List<Meai.SpeechToTextResponseUpdate>();
        bool sawEndOfStream = false;

        foreach (var frame in CapturedFrames)
        {
            var (update, endOfStream) = InworldClient.ParseServerFrame(frame, "resp-1");
            if (update is not null)
            {
                updates.Add(update);
            }
            if (endOfStream)
            {
                sawEndOfStream = true;
                break;
            }
        }

        //// The usage frame is the end-of-stream signal — we must see it,
        //// and we must see it AFTER every transcription frame.
        sawEndOfStream.Should().BeTrue(because: "the trailing usage frame signals end of stream");

        //// Every transcription frame (12 of them) maps to a MEAI update.
        updates.Count.Should().Be(12);

        //// Exactly one final update is emitted; the rest are interim.
        updates.Count(u => u.Kind == Meai.SpeechToTextResponseUpdateKind.TextUpdated).Should().Be(1);
        updates.Count(u => u.Kind == Meai.SpeechToTextResponseUpdateKind.TextUpdating).Should().Be(11);

        //// The sole final update carries the full transcript.
        var finalUpdate = updates.Single(u => u.Kind == Meai.SpeechToTextResponseUpdateKind.TextUpdated);
        finalUpdate.Text.Should().Be("Hello world, this is an in - world streaming test.");

        //// ResponseId propagates to every update.
        updates.Should().AllSatisfy(u => u.ResponseId.Should().Be("resp-1"));
    }

    [TestMethod]
    public void ReplayCapturedFrames_InterimOrderIsPreserved()
    {
        var interimTranscripts = new List<string>();
        foreach (var frame in CapturedFrames)
        {
            var (update, endOfStream) = InworldClient.ParseServerFrame(frame, responseId: null);
            if (update is { Kind.Value: "textupdating", Text: { Length: > 0 } text })
            {
                interimTranscripts.Add(text);
            }
            if (endOfStream)
            {
                break;
            }
        }

        //// Interim updates must be monotonically non-shrinking — each
        //// transcript is a prefix or extension of the previous one.
        for (var i = 1; i < interimTranscripts.Count; i++)
        {
            (interimTranscripts[i].Length >= interimTranscripts[i - 1].Length ||
             interimTranscripts[i] == interimTranscripts[i - 1])
                .Should().BeTrue(because:
                    $"interim #{i} (\"{interimTranscripts[i]}\") must not shrink below #{i - 1} (\"{interimTranscripts[i - 1]}\")");
        }
    }
}
