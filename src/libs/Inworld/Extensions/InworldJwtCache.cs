#nullable enable

using System.Globalization;

namespace Inworld;

/// <summary>
/// In-process cache for Inworld JWTs. Mint once per <c>(apiKey, resources)</c>
/// pair and reuse the token until it is about to expire, refreshing it in a
/// thread-safe way.
/// <para>
/// Typical usage on a Blazor/ASP.NET Core backend:
/// </para>
/// <code>
/// services.AddSingleton(new InworldJwtCache(apiKey, apiSecret, resources));
/// // later, when handing a token to a browser client:
/// var token = await cache.GetAsync(cancellationToken);
/// return token.Token;
/// </code>
/// </summary>
public sealed class InworldJwtCache : System.IDisposable
{
    private static readonly TimeSpan DefaultRefreshBuffer = TimeSpan.FromSeconds(60);

    private readonly string _apiKey;
    private readonly string _apiSecret;
    private readonly System.Collections.Generic.IReadOnlyList<string>? _resources;
    private readonly string? _host;
    private readonly HttpClient? _httpClient;
    private readonly TimeSpan _refreshBuffer;
    private readonly System.Threading.SemaphoreSlim _gate = new(1, 1);

    private InworldJwtToken? _token;
    private DateTimeOffset _refreshAt = DateTimeOffset.MinValue;

    /// <summary>
    /// Create a new JWT cache. <paramref name="refreshBuffer"/> defaults to 60
    /// seconds — tokens are treated as expired once the remaining lifetime
    /// drops below this threshold.
    /// </summary>
    public InworldJwtCache(
        string apiKey,
        string apiSecret,
        System.Collections.Generic.IReadOnlyList<string>? resources = null,
        string? host = null,
        HttpClient? httpClient = null,
        TimeSpan? refreshBuffer = null)
    {
        ArgumentException.ThrowIfNullOrEmpty(apiKey);
        ArgumentException.ThrowIfNullOrEmpty(apiSecret);

        _apiKey = apiKey;
        _apiSecret = apiSecret;
        _resources = resources;
        _host = host;
        _httpClient = httpClient;
        _refreshBuffer = refreshBuffer ?? DefaultRefreshBuffer;
    }

    /// <summary>
    /// Return a currently-valid JWT, minting a new one if the cached token is
    /// absent or within <c>refreshBuffer</c> of its expiration.
    /// </summary>
    public async System.Threading.Tasks.Task<InworldJwtToken> GetAsync(
        System.Threading.CancellationToken cancellationToken = default)
    {
        if (_token is { } cached && DateTimeOffset.UtcNow < _refreshAt)
        {
            return cached;
        }

        await _gate.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            if (_token is { } afterWait && DateTimeOffset.UtcNow < _refreshAt)
            {
                return afterWait;
            }

            var fresh = await InworldJwt.GenerateAsync(
                apiKey: _apiKey,
                apiSecret: _apiSecret,
                resources: _resources,
                host: _host,
                httpClient: _httpClient,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            _token = fresh;
            _refreshAt = ComputeRefreshAt(fresh, _refreshBuffer);
            return fresh;
        }
        finally
        {
            _gate.Release();
        }
    }

    /// <summary>
    /// Force the next <see cref="GetAsync"/> call to mint a new token. Useful
    /// when the server returns 401 and you want to rule out a stale token.
    /// </summary>
    public void Invalidate()
    {
        _token = null;
        _refreshAt = DateTimeOffset.MinValue;
    }

    /// <inheritdoc />
    public void Dispose() => _gate.Dispose();

    private static DateTimeOffset ComputeRefreshAt(InworldJwtToken token, TimeSpan refreshBuffer)
    {
        if (!string.IsNullOrEmpty(token.ExpirationTime) &&
            DateTimeOffset.TryParse(
                token.ExpirationTime,
                CultureInfo.InvariantCulture,
                DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal,
                out var expires))
        {
            var refreshAt = expires - refreshBuffer;

            // Sanity clamp: don't refresh earlier than 15s from now; that
            // signals a clock skew or a pathologically short TTL and we'd
            // rather serve a token than thrash the endpoint.
            var minRefreshAt = DateTimeOffset.UtcNow + TimeSpan.FromSeconds(15);
            return refreshAt > minRefreshAt ? refreshAt : minRefreshAt;
        }

        // Expiration missing — fall back to a conservative 30-minute TTL.
        return DateTimeOffset.UtcNow + TimeSpan.FromMinutes(30);
    }
}
