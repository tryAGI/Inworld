#nullable enable

namespace Inworld;

public partial class InworldClient
{
    /// <summary>
    /// Optional async token provider consulted by the realtime (WebSocket)
    /// streaming path before each connect. When set, the streaming clients
    /// fetch a fresh token from this provider instead of using the static
    /// API key passed to the constructor — typically wired to an
    /// <see cref="InworldJwtCache"/> so Blazor / ASP.NET Core backends can
    /// serve refreshed JWTs without reconstructing the client.
    /// </summary>
    public System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<string>>? RealtimeTokenProvider { get; set; }

    /// <summary>
    /// Convenience constructor that wires an <see cref="InworldJwtCache"/>
    /// for both REST (the JWT active at construction time) and realtime
    /// streaming (a fresh JWT is fetched from the cache before each
    /// WebSocket connect).
    /// </summary>
    /// <param name="jwtCache">A pre-configured JWT cache.</param>
    /// <param name="httpClient">Optional <see cref="System.Net.Http.HttpClient"/>.</param>
    /// <param name="baseUri">Optional base URI override.</param>
    /// <param name="disposeHttpClient">Whether to dispose the HttpClient on disposal. Defaults to true.</param>
    public InworldClient(
        InworldJwtCache jwtCache,
        System.Net.Http.HttpClient? httpClient = null,
        System.Uri? baseUri = null,
        bool disposeHttpClient = true)
        : this(
            apiKey: RequireToken(jwtCache),
            httpClient: httpClient,
            baseUri: baseUri,
            authorizations: null,
            disposeHttpClient: disposeHttpClient)
    {
        System.ArgumentNullException.ThrowIfNull(jwtCache);

        RealtimeTokenProvider = async ct =>
            (await jwtCache.GetAsync(ct).ConfigureAwait(false)).Token;

        // Register the cache so the REST PrepareRequest / ProcessResponse
        // hooks can refresh the token transparently and invalidate it on
        // 401/403.
        InworldJwtCacheRegistry.Register(Authorizations, jwtCache);
    }

    private static string RequireToken(InworldJwtCache jwtCache)
    {
        System.ArgumentNullException.ThrowIfNull(jwtCache);

        // Prime the cache synchronously so the REST Authorizations list has a
        // token on construction. Callers that need an all-async flow can use
        // the main `InworldClient(string apiKey)` constructor and set
        // `RealtimeTokenProvider` themselves.
        return jwtCache.GetAsync().GetAwaiter().GetResult().Token;
    }
}

/// <summary>
/// Binds an <see cref="InworldJwtCache"/> to a shared <c>Authorizations</c>
/// list so sub-clients (which only see the list, not the main
/// <see cref="InworldClient"/>) can refresh / invalidate tokens through the
/// same cache. Stored via <see cref="System.Runtime.CompilerServices.ConditionalWeakTable{TKey,TValue}"/>
/// so the cache is released as soon as the main client is collected.
/// </summary>
internal static class InworldJwtCacheRegistry
{
    private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<
        System.Collections.Generic.List<EndPointAuthorization>,
        InworldJwtCache> s_map = new();

    internal static void Register(
        System.Collections.Generic.List<EndPointAuthorization> authorizations,
        InworldJwtCache cache)
    {
        s_map.Remove(authorizations);
        s_map.Add(authorizations, cache);
    }

    internal static InworldJwtCache? Get(
        System.Collections.Generic.List<EndPointAuthorization> authorizations)
    {
        return s_map.TryGetValue(authorizations, out var cache) ? cache : null;
    }
}
