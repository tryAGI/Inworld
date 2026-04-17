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
