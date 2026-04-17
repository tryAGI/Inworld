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
/// <para>
/// When an <see cref="InworldJwtCache"/> was registered for this client (see
/// <see cref="InworldJwtCacheRegistry"/>), we also refresh the Authorization
/// token from the cache on each outgoing request and invalidate the cache
/// on a 401/403 response so the next request mints a fresh JWT.
/// </para>
/// </summary>
internal static class InworldAuthHook
{
    internal static void BeforeRequest(
        System.Collections.Generic.List<EndPointAuthorization> authorizations,
        System.Net.Http.HttpRequestMessage request)
    {
        RefreshFromCache(authorizations, request);
        RewriteBearerToBasic(request);
    }

    internal static void AfterResponse(
        System.Collections.Generic.List<EndPointAuthorization> authorizations,
        System.Net.Http.HttpResponseMessage response)
    {
        if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized ||
            response.StatusCode == System.Net.HttpStatusCode.Forbidden)
        {
            InworldJwtCacheRegistry.Get(authorizations)?.Invalidate();
        }
    }

    private static void RefreshFromCache(
        System.Collections.Generic.List<EndPointAuthorization> authorizations,
        System.Net.Http.HttpRequestMessage request)
    {
        var cache = InworldJwtCacheRegistry.Get(authorizations);
        if (cache is null)
        {
            return;
        }

        // Synchronous — the cache services hits without I/O. A miss only
        // happens near token expiry and blocks for the mint duration.
        var token = cache.GetAsync().GetAwaiter().GetResult().Token;
        request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
    }

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
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.BeforeRequest(Authorizations, request);

    partial void ProcessResponse(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpResponseMessage response) => InworldAuthHook.AfterResponse(Authorizations, response);
}

public partial class TextToSpeechClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.BeforeRequest(Authorizations, request);

    partial void ProcessResponse(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpResponseMessage response) => InworldAuthHook.AfterResponse(Authorizations, response);
}

public partial class SpeechToTextClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.BeforeRequest(Authorizations, request);

    partial void ProcessResponse(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpResponseMessage response) => InworldAuthHook.AfterResponse(Authorizations, response);
}

public partial class VoicesClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.BeforeRequest(Authorizations, request);

    partial void ProcessResponse(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpResponseMessage response) => InworldAuthHook.AfterResponse(Authorizations, response);
}

public partial class ModelsClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.BeforeRequest(Authorizations, request);

    partial void ProcessResponse(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpResponseMessage response) => InworldAuthHook.AfterResponse(Authorizations, response);
}
