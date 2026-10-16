#nullable enable

using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Inworld.Realtime;

namespace Inworld.IntegrationTests;

[TestClass]
public sealed class UnifiedRealtimeContractTests
{
    [TestMethod]
    public void SessionUpdate_RoundTripsTypedSettingsAndUnknownFields()
    {
        const string json = """
            {"type":"session.update","custom_event":{"sequence":7},"session":{"model":"test-model","audio":{"output":{"model":"inworld-tts-2","voice":"Sarah","custom_audio":[1,true,null]}},"providerData":{"tts":{"conversational":true,"delivery_mode":"CREATIVE","future_tts":{"x":1}},"stt":{"voice_profile":true},"new_provider":{"enabled":true}},"future_session":"kept"}}
            """;
        var message = UnifiedSessionUpdate.FromJson(json)!;
        message.Session.Audio!.Output!.Model.Should().Be(InworldTtsModels.RealtimeTts2);
        message.Session.ProviderData!.Tts!.Conversational.Should().BeTrue();
        message.Session.ProviderData.Stt!.VoiceProfile.Should().BeTrue();
        var actual = JsonNode.Parse(message.ToJson())!;
        var expected = JsonNode.Parse(json)!;
        actual["custom_event"]!.ToJsonString().Should().Be(expected["custom_event"]!.ToJsonString());
        actual["session"]!["future_session"]!.GetValue<string>().Should().Be("kept");
        actual["session"]!["audio"]!["output"]!["custom_audio"]!.ToJsonString().Should().Be("[1,true,null]");
        actual["session"]!["providerData"]!["tts"]!["future_tts"]!["x"]!.GetValue<int>().Should().Be(1);
        actual["session"]!["providerData"]!["new_provider"]!["enabled"]!.GetValue<bool>().Should().BeTrue();
    }

    [TestMethod]
    public void SessionUpdate_LeavesUnspecifiedPartialSettingsAbsent()
    {
        var message = new UnifiedSessionUpdate
        {
            Session = new UnifiedSession { Instructions = "Be concise." },
        };
        var json = JsonNode.Parse(message.ToJson())!;
        json["type"]!.GetValue<string>().Should().Be("session.update");
        json["session"]!["instructions"]!.GetValue<string>().Should().Be("Be concise.");
        json["session"]!["providerData"].Should().BeNull();
        json["session"]!["audio"].Should().BeNull();
    }

    [TestMethod]
    public void TypedToolAndAudioMessages_UseExpectedWireNames()
    {
        var audio = new UnifiedInputAudioBufferAppend { Audio = [1, 2, 3] };
        var json = JsonNode.Parse(audio.ToJson())!;
        json["type"]!.GetValue<string>().Should().Be("input_audio_buffer.append");
        json["audio"]!.GetValue<string>().Should().Be("AQID");
        var tool = new UnifiedConversationItemCreate
        {
            Item = new UnifiedConversationItem
            {
                Type = "function_call_output", CallId = "call-1", Output = "result",
            },
        };
        var toolJson = JsonNode.Parse(tool.ToJson())!;
        toolJson["item"]!["call_id"]!.GetValue<string>().Should().Be("call-1");
    }

    [TestMethod]
    [DataRow("portal-key", "Basic portal-key", false)]
    [DataRow("eyJsession-token", "Bearer eyJsession-token", false)]
    [DataRow("eyJfresh-token", "Bearer eyJfresh-token", true)]
    public async Task ConnectSession_SendsAuthSessionAndTypedUpdate(string token, string expectedHeader, bool refresh)
    {
        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        using var listener = StartListener();
        var request = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);
        var server = ServeAsync(listener, request, async socket =>
        {
            var buffer = new byte[8192];
            var received = await socket.ReceiveAsync(buffer.AsMemory(), timeout.Token);
            var update = JsonNode.Parse(buffer.AsSpan(0, received.Count))!;
            update["type"]!.GetValue<string>().Should().Be("session.update");
            update["session"]!["providerData"]!["tts"]!["conversational"]!.GetValue<bool>().Should().BeTrue();
        }, timeout.Token);
        using var client = new InworldUnifiedRealtimeClient(refresh ? "expired-key" : token);
        if (refresh) client.TokenProvider = _ => Task.FromResult(token);
        await client.ConnectSessionAsync("session +/你好", Endpoint(listener), timeout.Token);
        await client.SendUnifiedSessionUpdateAsync(new UnifiedSessionUpdate
        {
            Session = new UnifiedSession { ProviderData = new UnifiedProviderData { Tts = new UnifiedTtsProviderData { Conversational = true } } },
        }, timeout.Token);
        (await request.Task).Should().Contain("Authorization: " + expectedHeader)
            .And.Contain("GET /api/v1/realtime/session?key=session%20%2B%2F%E4%BD%A0%E5%A5%BD&protocol=realtime HTTP/1.1");
        await server;
    }

    [TestMethod]
    public async Task Receive_DecodesTypedEventsAndPreservesUnknownEventBetweenFragments()
    {
        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        using var listener = StartListener();
        var request = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);
        string[] frames =
        [
            """{"type":"session.created","event_id":"e1","session":{"id":"session-1","future_session":"retained"}}""",
            """{"type":"conversation.item.input_audio_transcription.completed","event_id":"e2","item_id":"item-1","content_index":0,"transcript":"你好","providerData":{"voiceProfile":{"emotion":[{"label":"happy","confidence":0.9,"future_label":7}]},"future_provider":{"a":1}},"future_event":true}""",
            """{"type":"future.event","payload":{"arr":[1,null,true]},"providerData":{"future":{"x":1}}}""",
            """{"type":"response.output_audio.delta","event_id":"e3","response_id":"r1","delta":"AQID","timestamp_info":{"word_alignment":{"words":["Hi"],"future_alignment":2}}}""",
            """{"type":"response.function_call_arguments.done","event_id":"e4","response_id":"r1","item_id":"item-2","output_index":0,"call_id":"call-1","name":"lookup","arguments":"{}"}""",
            """{"type":"error","event_id":"e5","error":{"type":"test_error","message":"test"}}""",
        ];
        var server = ServeAsync(listener, request, async socket =>
        {
            foreach (var frame in frames)
            {
                var bytes = Encoding.UTF8.GetBytes(frame);
                for (var i = 0; i < bytes.Length; i++)
                    await socket.SendAsync(bytes.AsMemory(i, 1), WebSocketMessageType.Text, i == bytes.Length - 1, timeout.Token);
            }
            await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "done", timeout.Token);
        }, timeout.Token);
        using var client = new InworldUnifiedRealtimeClient("portal-key");
        var unknown = new List<JsonElement>();
        client.UnknownMessage += (_, args) => unknown.Add(args.Json!.Value.Clone());
        await client.ConnectSessionAsync("test", Endpoint(listener), timeout.Token);
        var events = new List<UnifiedServerEvent>();
        await foreach (var update in client.ReceiveUpdatesAsync(timeout.Token)) events.Add(update);
        await server;
        events.Should().HaveCount(5);
        events[0].SessionCreated!.Session.Id.Should().Be("session-1");
        events[1].ConversationItemInputAudioTranscriptionCompleted!.Transcript.Should().Be("你好");
        var profile = events[1].ConversationItemInputAudioTranscriptionCompleted!.ProviderData!.VoiceProfile!;
        profile.Emotion![0].Label.Should().Be("happy");
        ((JsonElement)profile.Emotion[0].AdditionalProperties["future_label"]).GetInt32().Should().Be(7);
        events[2].ResponseOutputAudioDelta!.Delta.Should().Equal(1, 2, 3);
        events[2].ResponseOutputAudioDelta!.TimestampInfo!.WordAlignment!.Words.Should().Equal("Hi");
        events[3].ResponseFunctionCallArgumentsDone!.CallId.Should().Be("call-1");
        events[4].Error!.Error.Message.Should().Be("test");
        unknown.Should().HaveCount(1);
        unknown[0].GetProperty("type").GetString().Should().Be("future.event");
        unknown[0].GetProperty("payload").GetProperty("arr")[2].GetBoolean().Should().BeTrue();
        unknown[0].GetProperty("providerData").GetProperty("future").GetProperty("x").GetInt32().Should().Be(1);
    }

    [TestMethod]
    public void GuideSessionConfiguration_CompilesAndSerializesConversationalControls()
    {
        var message = new UnifiedSessionUpdate
        {
            Session = new UnifiedSession
            {
                Type = "realtime",
                Model = "openai/gpt-4o-mini",
                Instructions = "Be warm and concise. Use [speak softly] or [laugh] when appropriate.",
                OutputModalities = ["audio", "text"],
                Audio = new UnifiedSessionAudio
                {
                    Input = new UnifiedSessionAudioInput
                    {
                        Transcription = new UnifiedSessionAudioInputTranscription
                        {
                            Model = "inworld/inworld-stt-1",
                        },
                        TurnDetection = new UnifiedTurnDetection
                        {
                            Type = "semantic_vad", CreateResponse = true,
                        },
                    },
                    Output = new UnifiedSessionAudioOutput
                    {
                        Model = "inworld-tts-2", Voice = "Sarah",
                    },
                },
                ProviderData = new UnifiedProviderData
                {
                    Stt = new UnifiedSttProviderData { VoiceProfile = true },
                    Tts = new UnifiedTtsProviderData
                    {
                        Conversational = true,
                        UserTurnMode = "both",
                        DeliveryMode = "CREATIVE",
                        SegmenterStrategy = "full_turn",
                        SteeringHandling = "emit_once",
                    },
                },
            },
        };
        var json = JsonNode.Parse(message.ToJson())!;
        json["session"]!["audio"]!["input"]!["turn_detection"]!["type"]!.GetValue<string>().Should().Be("semantic_vad");
        json["session"]!["providerData"]!["tts"]!["conversational"]!.GetValue<bool>().Should().BeTrue();
    }

    private static TcpListener StartListener()
    {
        var listener = new TcpListener(IPAddress.Loopback, 0);
        listener.Start();
        return listener;
    }

    private static Uri Endpoint(TcpListener listener) => new($"ws://127.0.0.1:{((IPEndPoint)listener.LocalEndpoint).Port}/api/v1/realtime/session");

    private static async Task ServeAsync(TcpListener listener, TaskCompletionSource<string> request, Func<WebSocket, Task> handle, CancellationToken cancellationToken)
    {
        using var peer = await listener.AcceptTcpClientAsync(cancellationToken);
        await using var stream = peer.GetStream();
        using var reader = new StreamReader(stream, Encoding.ASCII, leaveOpen: true);
        var lines = new List<string>();
        while (await reader.ReadLineAsync(cancellationToken) is { Length: > 0 } line) lines.Add(line);
        request.SetResult(string.Join("\n", lines));
        var key = lines.Single(line => line.StartsWith("Sec-WebSocket-Key:", StringComparison.OrdinalIgnoreCase)).Split(':', 2)[1].Trim();
#pragma warning disable CA5350 // SHA-1 is required by the WebSocket handshake, used only in a local test.
        var accept = Convert.ToBase64String(System.Security.Cryptography.SHA1.HashData(Encoding.ASCII.GetBytes(key + "258EAFA5-E914-47DA-95CA-C5AB0DC85B11")));
#pragma warning restore CA5350
        await stream.WriteAsync(Encoding.ASCII.GetBytes($"HTTP/1.1 101 Switching Protocols\r\nUpgrade: websocket\r\nConnection: Upgrade\r\nSec-WebSocket-Accept: {accept}\r\n\r\n"), cancellationToken);
        using var socket = WebSocket.CreateFromStream(stream, isServer: true, subProtocol: null, keepAliveInterval: TimeSpan.FromSeconds(30));
        await handle(socket);
    }
}
