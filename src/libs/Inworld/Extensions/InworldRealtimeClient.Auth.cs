#nullable enable

namespace Inworld.Realtime;

/// <summary>
/// Shared helper for supplying the right <c>Authorization</c> header on an
/// Inworld WebSocket connect. Inworld accepts two scheme flavours:
/// <list type="bullet">
///   <item>JWTs — used unchanged as <c>Authorization: Bearer &lt;JWT&gt;</c>.
///         Detected by the <c>eyJ</c> Base64url prefix.</item>
///   <item>Portal API keys — pre-Base64-encoded; used as
///         <c>Authorization: Basic &lt;key&gt;</c>.</item>
/// </list>
/// The generated WebSocket clients store auth in
/// <c>_storedAuthorization*</c> fields and apply them from
/// <c>ApplyConnectionOptions</c> on <c>ConnectAsync</c>, so rewriting the
/// header from a partial constructor hook no longer sticks. Instead we
/// build the right <c>additionalHeaders</c> dictionary and pass it to the
/// connect overload — it is applied after the stored auth and wins.
/// </summary>
public static class InworldRealtimeAuth
{
    /// <summary>
    /// Build an <c>additionalHeaders</c> dictionary for <c>ConnectAsync</c>
    /// that forces the right scheme for the supplied <paramref name="apiKey"/>.
    /// Returns <c>null</c> when <paramref name="apiKey"/> is a JWT (Bearer is
    /// already correct) so callers can skip the allocation.
    /// </summary>
    public static System.Collections.Generic.IDictionary<string, string>? BuildConnectHeaders(string apiKey)
    {
        System.ArgumentException.ThrowIfNullOrEmpty(apiKey);

        if (apiKey.StartsWith("eyJ", System.StringComparison.Ordinal))
        {
            // JWT — the stored "Bearer <jwt>" header is correct.
            return null;
        }

        return new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase)
        {
            ["Authorization"] = $"Basic {apiKey}",
        };
    }
}

public partial class InworldSpeechToTextStreamRealtimeClient
{
    private string? _apiKey;
    private System.Net.WebSockets.ClientWebSocket? _ws;

    /// <summary>
    /// The API key / JWT passed to the bearer constructor, exposed so
    /// callers can build <c>additionalHeaders</c> for <c>ConnectAsync</c>.
    /// </summary>
    public string? StoredApiKey => _apiKey;

    /// <summary>
    /// Raw underlying WebSocket — intended for extension code that needs to
    /// parse JSON messages directly.
    /// </summary>
    internal System.Net.WebSockets.ClientWebSocket? RawWebSocket => _ws;

    partial void Initialized(System.Net.WebSockets.ClientWebSocket client)
    {
        _ws = client;
    }

    partial void Authorizing(System.Net.WebSockets.ClientWebSocket client, ref string apiKey)
    {
        _apiKey = apiKey;
    }
}

public partial class InworldTextToSpeechStreamRealtimeClient
{
    private string? _apiKey;
    private System.Net.WebSockets.ClientWebSocket? _ws;

    /// <summary>
    /// The API key / JWT passed to the bearer constructor, exposed so
    /// callers can build <c>additionalHeaders</c> for <c>ConnectAsync</c>.
    /// </summary>
    public string? StoredApiKey => _apiKey;

    /// <summary>
    /// Raw underlying WebSocket — intended for extension code that needs to
    /// parse JSON messages directly.
    /// </summary>
    internal System.Net.WebSockets.ClientWebSocket? RawWebSocket => _ws;

    partial void Initialized(System.Net.WebSockets.ClientWebSocket client)
    {
        _ws = client;
    }

    partial void Authorizing(System.Net.WebSockets.ClientWebSocket client, ref string apiKey)
    {
        _apiKey = apiKey;
    }
}
