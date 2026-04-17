/*
order: 70
title: MEAI Streaming Speech-to-Text
slug: meai-streaming-speech-to-text

End-to-end round trip: synthesize a short phrase with Inworld TTS at
LINEAR16/16kHz, then feed the resulting audio back through the MEAI
`GetStreamingTextAsync` pipeline (which uses Inworld's STT WebSocket
under the hood) and confirm that a non-empty transcript comes back.
*/

#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using Meai = Microsoft.Extensions.AI;

namespace Inworld.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(60_000)]
    public async Task Example_StreamingSpeechToText_RoundTrip()
    {
        using var client = GetAuthenticatedClient();

        //// 1. Synthesize a known phrase with LINEAR16 / 16 kHz — an encoding
        ////    Inworld's streaming STT accepts directly.
        const string phrase = "Hello world. This is an Inworld streaming test.";

        var tts = await client.TextToSpeech.SynthesizeSpeechAsync(
            text: phrase,
            voiceId: "Dennis",
            modelId: "inworld-tts-1.5-max",
            audioConfig: new AudioConfig
            {
                AudioEncoding = AudioEncoding.Linear16,
                SampleRateHertz = 16000,
            });

        tts.AudioContent.Should().NotBeNull();
        var audioBytes = StripWavHeader(tts.AudioContent!);
        audioBytes.Length.Should().BeGreaterThan(1000, because: "some audio should have been produced");

        //// 2. Feed the audio back through MEAI ISpeechToTextClient — streaming path.
        Meai.ISpeechToTextClient speech = client;

        using var audioStream = new MemoryStream(audioBytes);
        var options = new Meai.SpeechToTextOptions
        {
            ModelId = "assemblyai/universal-streaming-multilingual",
            SpeechLanguage = "en-US",
        };

        var updates = new List<Meai.SpeechToTextResponseUpdate>();
        await foreach (var update in speech.GetStreamingTextAsync(audioStream, options, CancellationToken.None))
        {
            updates.Add(update);
            if (update.Kind == Meai.SpeechToTextResponseUpdateKind.SessionClose)
            {
                break;
            }
        }

        //// 3. Verify we got a transcription event somewhere in the stream.
        var transcript = string.Concat(updates
            .Where(u => u.Kind == Meai.SpeechToTextResponseUpdateKind.TextUpdated)
            .Select(u => u.Text ?? string.Empty));

        if (string.IsNullOrWhiteSpace(transcript))
        {
            transcript = string.Concat(updates
                .Where(u => u.Kind == Meai.SpeechToTextResponseUpdateKind.TextUpdating)
                .Select(u => u.Text ?? string.Empty));
        }

        transcript.Should().NotBeNullOrWhiteSpace(because: "the STT stream should emit at least interim transcripts for the synthesized phrase");
    }

    private static byte[] StripWavHeader(byte[] audio)
    {
        // Inworld TTS may return LINEAR16 wrapped in a 44-byte RIFF/WAV header;
        // strip it so the STT stream receives raw PCM only.
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
