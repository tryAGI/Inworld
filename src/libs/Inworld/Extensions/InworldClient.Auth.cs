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
/// Rather than hook every sub-client's synchronous <c>PrepareRequest</c> partial
/// and pay a sync-over-async cost when the JWT cache needs refreshing, we
/// register a single <see cref="IAutoSDKHook"/> on the shared
/// <see cref="AutoSDKClientOptions"/> that runs asynchronously before every
/// outgoing REST request — and invalidates the cache on 401/403 so the next
/// call mints a fresh token automatically.
/// </summary>
[CLSCompliant(false)]
public sealed class InworldAuthHook : AutoSDKHook
{
    private readonly System.Collections.Generic.List<EndPointAuthorization> _authorizations;

    internal InworldAuthHook(System.Collections.Generic.List<EndPointAuthorization> authorizations)
    {
        _authorizations = authorizations;
    }

    /// <inheritdoc />
    public override async System.Threading.Tasks.Task OnBeforeRequestAsync(AutoSDKHookContext context)
    {
        System.ArgumentNullException.ThrowIfNull(context);

        var request = context.Request;

        // If a JwtCache is registered for this client, refresh the token
        // asynchronously. Cache hits return immediately; misses await the
        // mint without blocking any calling thread.
        var cache = InworldJwtCacheRegistry.Get(_authorizations);
        if (cache is not null)
        {
            var token = (await cache.GetAsync(context.CancellationToken).ConfigureAwait(false)).Token;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        RewriteBearerToBasic(request);
    }

    /// <inheritdoc />
    public override System.Threading.Tasks.Task OnAfterErrorAsync(AutoSDKHookContext context)
    {
        System.ArgumentNullException.ThrowIfNull(context);

        if (context.Response is { } response &&
            (response.StatusCode == System.Net.HttpStatusCode.Unauthorized ||
             response.StatusCode == System.Net.HttpStatusCode.Forbidden))
        {
            InworldJwtCacheRegistry.Get(_authorizations)?.Invalidate();
        }

        return System.Threading.Tasks.Task.CompletedTask;
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
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        // Register the async auth hook exactly once per client. Sub-clients
        // share this same Options instance, so the hook covers all REST
        // sub-clients (TextToSpeech, SpeechToText, Voices, Models).
        if (Options.Hooks.Count == 0 || !Options.Hooks.Exists(h => h is InworldAuthHook))
        {
            Options.AddHook(new InworldAuthHook(Authorizations));
        }
    }
}
