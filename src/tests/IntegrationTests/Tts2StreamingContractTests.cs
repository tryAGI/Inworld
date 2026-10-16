#nullable enable

using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json.Nodes;
using Inworld.Realtime;

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
    public async Task Conversation_ReassemblesUtf8AndPreservesAllProtocolFields()
    {
        using var socket = new ReplayWebSocket(
            """{"type":"session.created","session":{"id":"test"}}""",
            """{"type":"conversation.item.input_audio_transcription.completed","transcript":"你好","providerData":{"voiceProfile":{"emotion":"happy"}}}""",
            """{"type":"response.audio.delta","delta":"AQID"}""",
            """{"type":"response.function_call_arguments.done","call_id":"call-1","arguments":"{}"}""",
            """{"type":"error","error":{"code":"test_error"}}""");
        using var client = new InworldConversationClient(socket);
        await client.SendAsync(JsonNode.Parse("""
            {"type":"session.update","session":{"audio":{"output":{"model":"inworld-tts-2","voice":"Sarah"}},"providerData":{"stt":{"voice_profile":true},"tts":{"conversational":true,"user_turn_mode":"both","delivery_mode":"CREATIVE"}}}}
            """)!.AsObject());
        var sent = JsonNode.Parse(socket.Sent.Single())!;
        sent["session"]!["providerData"]!["tts"]!["conversational"]!.GetValue<bool>().Should().BeTrue();
        sent["session"]!["audio"]!["output"]!["model"]!.GetValue<string>().Should().Be(InworldTtsModels.RealtimeTts2);
        var events = new List<JsonObject>();
        await foreach (var update in client.ReceiveUpdatesAsync())
        {
            events.Add(update);
        }
        events.Should().HaveCount(5);
        events[1]["transcript"]!.GetValue<string>().Should().Be("你好");
        events[1]["providerData"]!["voiceProfile"]!["emotion"]!.GetValue<string>().Should().Be("happy");
        events[2]["delta"]!.GetValue<string>().Should().Be("AQID");
        events[3]["call_id"]!.GetValue<string>().Should().Be("call-1");
        events[4]["error"]!["code"]!.GetValue<string>().Should().Be("test_error");
        socket.CloseAcknowledged.Should().BeTrue();
    }

    [TestMethod]
    public async Task Conversation_EnforcesMessageSizeAndCancellation()
    {
        using var socket = new ReplayWebSocket("""{"type":"session.created"}""");
        using var client = new InworldConversationClient(socket);
        Func<Task> oversized = async () =>
        {
            await foreach (var _ in client.ReceiveUpdatesAsync(maxMessageBytes: 5)) { }
        };
        await oversized.Should().ThrowAsync<InvalidDataException>();
        using var canceled = new CancellationTokenSource();
        await canceled.CancelAsync();
        Func<Task> read = async () =>
        {
            await foreach (var _ in client.ReceiveUpdatesAsync(cancellationToken: canceled.Token)) { }
        };
        await read.Should().ThrowAsync<OperationCanceledException>();
        Func<Task> send = () => client.SendAsync(new JsonObject { ["type"] = "response.cancel" }, canceled.Token);
        await send.Should().ThrowAsync<OperationCanceledException>();
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

    [TestMethod]
    [DataRow("portal-key", "Basic portal-key", false)]
    [DataRow("eyJsession-token", "Bearer eyJsession-token", false)]
    [DataRow("eyJfresh-token", "Bearer eyJfresh-token", true)]
    public async Task Conversation_ConnectAuthenticatesAndEscapesSessionId(string token, string expectedHeader, bool refresh)
    {
        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(10));
        using var listener = new System.Net.Sockets.TcpListener(IPAddress.Loopback, 0);
        listener.Start();
        var port = ((IPEndPoint)listener.LocalEndpoint).Port;
        var handshake = AcceptHandshakeAsync(listener, timeout.Token);
        using var client = new InworldConversationClient(refresh ? "expired-key" : token);
        if (refresh) client.TokenProvider = _ => Task.FromResult(token);
        await client.ConnectAsync("session +/你好", new Uri($"ws://127.0.0.1:{port}/api/v1/realtime/session"), timeout.Token);
        var headers = await handshake;
        headers.Should().Contain("Authorization: " + expectedHeader);
        headers.Should().Contain("GET /api/v1/realtime/session?key=session%20%2B%2F%E4%BD%A0%E5%A5%BD&protocol=realtime HTTP/1.1");
    }

    private static async Task<string> AcceptHandshakeAsync(System.Net.Sockets.TcpListener listener, CancellationToken cancellationToken)
    {
        using var peer = await listener.AcceptTcpClientAsync(cancellationToken);
        await using var stream = peer.GetStream();
        using var reader = new StreamReader(stream, Encoding.ASCII, leaveOpen: true);
        var lines = new List<string>();
        while (await reader.ReadLineAsync(cancellationToken) is { Length: > 0 } line) lines.Add(line);
        var key = lines.Single(line => line.StartsWith("Sec-WebSocket-Key:", StringComparison.OrdinalIgnoreCase)).Split(':', 2)[1].Trim();
        // SHA-1 is mandated by the WebSocket handshake; this is a local protocol test.
#pragma warning disable CA5350
        var accept = Convert.ToBase64String(System.Security.Cryptography.SHA1.HashData(
            Encoding.ASCII.GetBytes(key + "258EAFA5-E914-47DA-95CA-C5AB0DC85B11")));
#pragma warning restore CA5350
        var response = Encoding.ASCII.GetBytes($"HTTP/1.1 101 Switching Protocols\r\nUpgrade: websocket\r\nConnection: Upgrade\r\nSec-WebSocket-Accept: {accept}\r\n\r\n");
        await stream.WriteAsync(response, cancellationToken);
        return string.Join("\n", lines);
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

    private sealed class ReplayWebSocket(params string[] messages) : WebSocket
    {
        private readonly Queue<byte[]> _messages = new(messages.Select(Encoding.UTF8.GetBytes));
        private int _offset;
        private WebSocketState _state = WebSocketState.Open;
        public List<string> Sent { get; } = [];
        public bool CloseAcknowledged { get; private set; }
        public override WebSocketCloseStatus? CloseStatus => WebSocketCloseStatus.NormalClosure;
        public override string? CloseStatusDescription => null;
        public override WebSocketState State => _state;
        public override string? SubProtocol => null;
        public override void Abort() => _state = WebSocketState.Aborted;
        public override void Dispose() => _state = WebSocketState.Closed;
        public override Task CloseAsync(WebSocketCloseStatus closeStatus, string? statusDescription, CancellationToken cancellationToken) =>
            CloseOutputAsync(closeStatus, statusDescription, cancellationToken);
        public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string? statusDescription, CancellationToken cancellationToken)
        {
            CloseAcknowledged = true;
            _state = WebSocketState.Closed;
            return Task.CompletedTask;
        }
        public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            Sent.Add(Encoding.UTF8.GetString(buffer));
            return Task.CompletedTask;
        }
        public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (_messages.Count == 0)
            {
                _state = WebSocketState.CloseReceived;
                return Task.FromResult(new WebSocketReceiveResult(0, WebSocketMessageType.Close, true));
            }
            var message = _messages.Peek();
            // Fragment at every byte, including inside multibyte UTF-8 characters.
            buffer.AsSpan()[0] = message[_offset++];
            var end = _offset == message.Length;
            if (end) { _messages.Dequeue(); _offset = 0; }
            return Task.FromResult(new WebSocketReceiveResult(1, WebSocketMessageType.Text, end));
        }
    }
}
