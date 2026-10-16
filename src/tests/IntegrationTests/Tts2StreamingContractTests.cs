#nullable enable

using System.Net;
using System.Text;
using System.Text.Json.Nodes;

namespace Inworld.IntegrationTests;

[TestClass]
public sealed class Tts2StreamingContractTests
{
    [TestMethod]
    public async Task HttpStream_PreservesAudioTrailingTimestampsUsageAndErrors()
    {
        using var handler = new StreamingHandler();
        using var http = new HttpClient(handler);
        using var client = new InworldClient("portal-key", httpClient: http);
        var messages = new List<SynthesizeSpeechStreamResponse>();
        await foreach (var message in client.TextToSpeech.SynthesizeSpeechStreamAsync(new SynthesizeSpeechRequest
        {
            Text = "Hey [laugh]. ¿Cómo estás? お疲れさま。",
            VoiceId = "Sarah",
            ModelId = InworldTtsModels.RealtimeTts2,
            Instruction = "Warm and relaxed",
            DeliveryMode = DeliveryMode.Creative,
        }))
        {
            messages.Add(message);
        }

        handler.Uri!.AbsolutePath.Should().Be("/tts/v1/voice:stream");
        handler.Authorization.Should().Be("Basic portal-key");
        handler.Accept.Should().Be("application/json");
        var request = JsonNode.Parse(handler.Body!)!;
        request["text"]!.GetValue<string>().Should().Contain("[laugh]").And.Contain("お疲れさま");
        request["instruction"]!.GetValue<string>().Should().Be("Warm and relaxed");
        request["deliveryMode"]!.GetValue<string>().Should().Be("CREATIVE");
        messages.Should().HaveCount(3);
        messages[0].Result!.AudioContent.Should().Equal(1, 2, 3);
        messages[0].Result!.Usage!.ProcessedCharactersCount.Should().Be(42);
        messages[1].Result!.AudioContent.Should().BeNull();
        messages[1].Result!.TimestampInfo!.WordAlignment!.Words.Should().Equal("Hey");
        messages[2].Error!.Code.Should().Be(8);
    }

    [TestMethod]
    public async Task HttpStream_RejectsUnsuccessfulHttpStatus()
    {
        using var handler = new StreamingHandler { Status = HttpStatusCode.Unauthorized };
        using var http = new HttpClient(handler);
        using var client = new InworldClient("portal-key", httpClient: http);
        Func<Task> read = async () =>
        {
            await foreach (var _ in client.TextToSpeech.SynthesizeSpeechStreamAsync(
                new SynthesizeSpeechRequest { Text = "Hi", VoiceId = "Sarah", ModelId = InworldTtsModels.RealtimeTts2 }))
            {
                Assert.Fail("An HTTP error must not yield audio.");
            }
        };
        await read.Should().ThrowAsync<ApiException>();
    }

    [TestMethod]
    public async Task HttpStream_CancellationInterruptsAStalledBody()
    {
        using var handler = new StalledHandler();
        using var http = new HttpClient(handler);
        using var client = new InworldClient("portal-key", httpClient: http);
        using var canceled = new CancellationTokenSource();
        await using var enumerator = client.TextToSpeech.SynthesizeSpeechStreamAsync(
            new SynthesizeSpeechRequest { Text = "Hi", VoiceId = "Sarah", ModelId = InworldTtsModels.RealtimeTts2 },
            cancellationToken: canceled.Token).GetAsyncEnumerator();
        var pending = enumerator.MoveNextAsync().AsTask();
        await handler.Stream.ReadStarted.Task.WaitAsync(TimeSpan.FromSeconds(5));
        await canceled.CancelAsync();
        Func<Task> finish = async () => await pending.WaitAsync(TimeSpan.FromSeconds(5));
        await finish.Should().ThrowAsync<OperationCanceledException>();
    }

    private sealed class StalledHandler : HttpMessageHandler
    {
        public StalledStream Stream { get; } = new();
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
            Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK) { Content = new StreamContent(Stream) });
    }

    private sealed class StalledStream : MemoryStream
    {
        public TaskCompletionSource ReadStarted { get; } = new(TaskCreationOptions.RunContinuationsAsynchronously);
        public override int Read(byte[] buffer, int offset, int count) =>
            throw new InvalidOperationException("A streaming response must not synchronously read the network.");
        public override async ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
        {
            ReadStarted.TrySetResult();
            await Task.Delay(Timeout.InfiniteTimeSpan, cancellationToken);
            return 0;
        }
    }

    private sealed class StreamingHandler : HttpMessageHandler
    {
        public Uri? Uri { get; private set; }
        public string? Authorization { get; private set; }
        public string? Accept { get; private set; }
        public string? Body { get; private set; }
        public HttpStatusCode Status { get; init; } = HttpStatusCode.OK;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Uri = request.RequestUri;
            Authorization = request.Headers.Authorization?.ToString();
            Accept = request.Headers.Accept.ToString();
            Body = await request.Content!.ReadAsStringAsync(cancellationToken);
            var payload = """
                {"result":{"audioContent":"AQID","usage":{"processedCharactersCount":42}}}

                {"result":{"timestampInfo":{"wordAlignment":{"words":["Hey"],"wordStartTimeSeconds":[0],"wordEndTimeSeconds":[0.3]}}}}
                {"error":{"code":8,"message":"quota"}}
                """;
            // One-byte reads split JSON, base64, and line boundaries independently.
            return new HttpResponseMessage(Status)
            {
                Content = new StreamContent(new BytewiseStream(Encoding.UTF8.GetBytes(payload))),
            };
        }
    }

    private sealed class BytewiseStream(byte[] bytes) : MemoryStream(bytes)
    {
        public override int Read(byte[] buffer, int offset, int count) => base.Read(buffer, offset, Math.Min(1, count));
        public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default) =>
            base.ReadAsync(buffer[..Math.Min(1, buffer.Length)], cancellationToken);
    }

}
