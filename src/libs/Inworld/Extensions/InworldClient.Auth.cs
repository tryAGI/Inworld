#nullable enable

namespace Inworld;

/// <summary>
/// Inworld supports two auth flavours that both travel on the standard
/// <c>Authorization</c> header:
/// <list type="bullet">
///   <item>Server-side: <c>Authorization: Basic &lt;base64-api-key&gt;</c> where
///         the key issued by the Inworld Portal is already Base64-encoded.</item>
///   <item>Client-side (Blazor, browser, mobile): <c>Authorization: Bearer &lt;JWT&gt;</c>
///         where the JWT is obtained by exchanging the API key + secret via
///         <see cref="InworldJwt.GenerateAsync"/>.</item>
/// </list>
/// The generated client always emits <c>Bearer &lt;value&gt;</c>, so on each
/// outgoing request we peek at the token and rewrite the scheme to
/// <c>Basic</c> unless the token looks like a JWT (starts with <c>eyJ</c>).
/// </summary>
internal static class InworldAuthHook
{
    internal static void RewriteBearerToBasic(System.Net.Http.HttpRequestMessage request)
    {
        var auth = request.Headers.Authorization;
        if (auth is not { Scheme: "Bearer", Parameter: { Length: > 0 } key })
        {
            return;
        }

        if (key.StartsWith("eyJ", System.StringComparison.Ordinal))
        {
            // JWT — leave the Bearer scheme alone.
            return;
        }

        request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", key);
    }
}

public partial class InworldClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.RewriteBearerToBasic(request);
}

public partial class TextToSpeechClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.RewriteBearerToBasic(request);
}

public partial class SpeechToTextClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.RewriteBearerToBasic(request);
}

public partial class VoicesClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.RewriteBearerToBasic(request);
}

public partial class ModelsClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.RewriteBearerToBasic(request);
}
