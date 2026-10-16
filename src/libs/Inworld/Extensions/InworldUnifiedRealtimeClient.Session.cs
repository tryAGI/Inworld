#nullable enable

namespace Inworld.Realtime;

public partial class InworldUnifiedRealtimeClient
{
    /// <summary>Optional fresh session JWT provider, consulted before ConnectSessionAsync.</summary>
    public System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<string>>? TokenProvider { get; set; }

    /// <summary>
    /// Connect to the unified Realtime endpoint with an application session ID and
    /// Basic API-key or Bearer session-JWT authentication. Call before sending events.
    /// Read session.created, then send a typed UnifiedSessionUpdate.
    /// </summary>
    public async System.Threading.Tasks.Task ConnectSessionAsync(
        string sessionId,
        System.Uri? baseUri = null,
        System.Threading.CancellationToken cancellationToken = default)
    {
        System.ArgumentException.ThrowIfNullOrEmpty(sessionId);
        var token = TokenProvider is { } provider
            ? await provider(cancellationToken).ConfigureAwait(false)
            : _storedAuthorizationApiKey;
        System.ArgumentException.ThrowIfNullOrEmpty(token);
        AuthorizeUsingBearer(token);

        var uri = new System.UriBuilder(baseUri ?? new System.Uri(DefaultBaseUrl));
        var query = uri.Query.TrimStart('?');
        uri.Query = (query.Length > 0 ? query + "&" : "") +
            $"key={System.Uri.EscapeDataString(sessionId)}&protocol=realtime";
        await ConnectAsync(
            uri: uri.Uri,
            additionalHeaders: InworldRealtimeAuth.BuildConnectHeaders(token),
            cancellationToken: cancellationToken).ConfigureAwait(false);
    }
}
