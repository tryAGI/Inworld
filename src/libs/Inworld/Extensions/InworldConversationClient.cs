#nullable enable

using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Inworld.Realtime;

/// <summary>
/// Unified speech-to-speech Realtime connection. JSON events preserve the complete
/// OpenAI-compatible protocol and Inworld providerData extensions without reflection.
/// Use one receive loop per connection; sends are serialized. Reconnect explicitly
/// with a new client so conversation events are never silently replayed.
/// </summary>
public sealed class InworldConversationClient : IDisposable
{
    /// <summary>The unified Realtime WebSocket endpoint.</summary>
    public const string DefaultBaseUrl = "wss://api.inworld.ai/api/v1/realtime/session";

    private readonly WebSocket _socket;
    private readonly string? _apiKey;
    private readonly SemaphoreSlim _sendGate = new(1, 1);
    private int _receiving;

    /// <summary>Create a connection using a Portal API key or a backend-minted session JWT.</summary>
    public InworldConversationClient(string apiKey)
    {
        ArgumentException.ThrowIfNullOrEmpty(apiKey);
        _apiKey = apiKey;
        _socket = new ClientWebSocket();
    }

    /// <summary>Use an already connected WebSocket. This client takes ownership of it.</summary>
    public InworldConversationClient(WebSocket connectedSocket)
    {
        ArgumentNullException.ThrowIfNull(connectedSocket);
        if (connectedSocket.State != WebSocketState.Open)
        {
            throw new ArgumentException("The WebSocket must be open.", nameof(connectedSocket));
        }
        _socket = connectedSocket;
    }

    /// <summary>Optional fresh session JWT provider, consulted before connecting.</summary>
    public Func<CancellationToken, Task<string>>? TokenProvider { get; set; }

    /// <summary>Connect with an application session ID. Read session.created before configuring the session.</summary>
    public async Task ConnectAsync(
        string sessionId,
        Uri? baseUri = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);
        if (_socket is not ClientWebSocket socket || socket.State != WebSocketState.None)
        {
            throw new InvalidOperationException("Create a new client for each connection.");
        }

        var token = TokenProvider is { } provider
            ? await provider(cancellationToken).ConfigureAwait(false)
            : _apiKey!;
        ArgumentException.ThrowIfNullOrEmpty(token);
        socket.Options.SetRequestHeader("Authorization",
            $"{(token.StartsWith("eyJ", StringComparison.Ordinal) ? "Bearer" : "Basic")} {token}");
        var uri = new UriBuilder(baseUri ?? new Uri(DefaultBaseUrl));
        var query = uri.Query.TrimStart('?');
        uri.Query = (query.Length > 0 ? query + "&" : "") +
            $"key={Uri.EscapeDataString(sessionId)}&protocol=realtime";
        await socket.ConnectAsync(uri.Uri, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Send any protocol event, including session.update, input_audio_buffer.append,
    /// conversation.item.create, response.create, response.cancel, and function outputs.
    /// Session options use snake_case, except Inworld's camelCase providerData key.
    /// </summary>
    public async Task SendAsync(JsonObject message, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(message);
        if (message["type"] is not JsonValue type || !type.TryGetValue<string>(out var name) ||
            string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("A Realtime event needs a nonempty string type.", nameof(message));
        }
        var bytes = JsonSerializer.SerializeToUtf8Bytes(message, RealtimeJsonContext.Default.JsonObject);
        await _sendGate.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            await _socket.SendAsync(bytes.AsMemory(), WebSocketMessageType.Text, true, cancellationToken)
                .ConfigureAwait(false);
        }
        finally
        {
            _sendGate.Release();
        }
    }

    /// <summary>
    /// Receive complete JSON events, including audio deltas, transcripts, tool calls,
    /// voice profiles, usage, and error events. Inspect each event's type; server error
    /// events are returned to the caller. Fragmented UTF-8 messages are reassembled.
    /// A normal close ends enumeration; abnormal closes and malformed events throw.
    /// Cancellation terminates the receive operation; dispose the connection afterwards.
    /// </summary>
    public async IAsyncEnumerable<JsonObject> ReceiveUpdatesAsync(
        int maxMessageBytes = 16 * 1024 * 1024,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(maxMessageBytes);
        if (Interlocked.Exchange(ref _receiving, 1) != 0)
        {
            throw new InvalidOperationException("Only one receive loop is allowed per connection.");
        }
        try
        {
            var buffer = new byte[8192];
            while (true)
            {
                using var message = new MemoryStream();
                ValueWebSocketReceiveResult part;
                do
                {
                    part = await _socket.ReceiveAsync(buffer.AsMemory(), cancellationToken).ConfigureAwait(false);
                    if (part.MessageType == WebSocketMessageType.Close)
                    {
                        if (_socket.CloseStatus != WebSocketCloseStatus.NormalClosure)
                        {
                            throw new WebSocketException("The Realtime server closed the connection abnormally.");
                        }
                        await _sendGate.WaitAsync(cancellationToken).ConfigureAwait(false);
                        try
                        {
                            await _socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, null, cancellationToken)
                                .ConfigureAwait(false);
                        }
                        finally
                        {
                            _sendGate.Release();
                        }
                        yield break;
                    }
                    if (part.MessageType != WebSocketMessageType.Text)
                    {
                        throw new InvalidDataException("Expected a JSON text event.");
                    }
                    if (message.Length + part.Count > maxMessageBytes)
                    {
                        throw new InvalidDataException("The Realtime event exceeds the configured size limit.");
                    }
                    await message.WriteAsync(buffer.AsMemory(0, part.Count), cancellationToken).ConfigureAwait(false);
                } while (!part.EndOfMessage);

                var json = JsonNode.Parse(message.GetBuffer().AsSpan(0, (int)message.Length)) as JsonObject
                    ?? throw new JsonException("Expected a JSON object event.");
                yield return json;
            }
        }
        finally
        {
            Volatile.Write(ref _receiving, 0);
        }
    }

    /// <summary>Release the owned WebSocket. Cancel and await active operations before disposing.</summary>
    public void Dispose()
    {
        _socket.Dispose();
        _sendGate.Dispose();
    }
}
