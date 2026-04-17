#nullable enable

namespace Inworld.Realtime;

/// <summary>
/// Shared helper for rewriting the WebSocket Authorization header from
/// Bearer → Basic for Inworld API keys. JWTs (which start with "eyJ") are
/// left untouched so client-side/Blazor use-cases just work.
/// </summary>
internal static class InworldRealtimeAuthHook
{
    internal static void RewriteBearerToBasicHeader(System.Net.WebSockets.ClientWebSocket client, string apiKey)
    {
        if (apiKey.StartsWith("eyJ", System.StringComparison.Ordinal))
        {
            // Already a JWT — keep the Bearer scheme set by AuthorizeUsingBearer.
            return;
        }

        // Base64 API key from the Portal — rewrite scheme to Basic.
        client.Options.SetRequestHeader("Authorization", $"Basic {apiKey}");
    }
}

public partial class InworldSpeechToTextStreamRealtimeClient
{
    private string? _apiKey;
    private System.Net.WebSockets.ClientWebSocket? _ws;

    /// <summary>
    /// Raw underlying WebSocket — intended for extension code that needs to
    /// parse JSON messages directly instead of via the generated
    /// discriminated-union helper.
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

    partial void Authorized(System.Net.WebSockets.ClientWebSocket client)
    {
        if (_apiKey is { Length: > 0 } key)
        {
            InworldRealtimeAuthHook.RewriteBearerToBasicHeader(client, key);
        }
    }
}

public partial class InworldTextToSpeechStreamRealtimeClient
{
    private string? _apiKey;
    private System.Net.WebSockets.ClientWebSocket? _ws;

    /// <summary>
    /// Raw underlying WebSocket — intended for extension code that needs to
    /// parse JSON messages directly instead of via the generated
    /// discriminated-union helper.
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

    partial void Authorized(System.Net.WebSockets.ClientWebSocket client)
    {
        if (_apiKey is { Length: > 0 } key)
        {
            InworldRealtimeAuthHook.RewriteBearerToBasicHeader(client, key);
        }
    }
}
