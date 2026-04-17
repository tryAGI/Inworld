#nullable enable

using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Inworld;

/// <summary>
/// Exchanges an Inworld API key + secret pair for a short-lived JWT via
/// Inworld's <c>/auth/v1/tokens/token:generate</c> endpoint.
/// <para>
/// Use this on a trusted backend to mint tokens for client-side (Blazor,
/// browser, mobile) applications. The returned JWT can be passed to
/// <c>new InworldClient(jwt)</c> or the realtime clients and is handled
/// transparently (the auth hook keeps the Bearer scheme for JWTs).
/// </para>
/// </summary>
public static class InworldJwt
{
    private const string EngineHost = "api-engine.inworld.ai";
    private const string Method = "ai.inworld.engine.WorldEngine/GenerateToken";
    private const string DefaultHost = "api.inworld.ai";

    /// <summary>
    /// Generate a short-lived Inworld JWT.
    /// </summary>
    /// <param name="apiKey">The Inworld API key (the "JWT key" portion from the Portal, not the Base64-encoded combined key).</param>
    /// <param name="apiSecret">The matching Inworld API secret.</param>
    /// <param name="resources">Optional list of resources to scope the token to (e.g. <c>workspaces/&lt;id&gt;</c>).</param>
    /// <param name="host">Optional host override. Defaults to <c>api.inworld.ai</c>.</param>
    /// <param name="httpClient">Optional <see cref="HttpClient"/> to use. A new one is created when omitted.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public static async System.Threading.Tasks.Task<InworldJwtToken> GenerateAsync(
        string apiKey,
        string apiSecret,
        System.Collections.Generic.IReadOnlyList<string>? resources = null,
        string? host = null,
        HttpClient? httpClient = null,
        System.Threading.CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(apiKey);
        ArgumentException.ThrowIfNullOrEmpty(apiSecret);

        host ??= DefaultHost;

        var datetime = System.DateTime.UtcNow.ToString("yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
        var nonce = GenerateNonce();
        var signature = ComputeSignature(apiSecret, datetime, EngineHost, Method, nonce);

        HttpClient? ownedHttp = null;
        if (httpClient is null)
        {
            ownedHttp = new HttpClient();
            httpClient = ownedHttp;
        }

        try
        {
            var payload = new InworldJwtRequestBody(apiKey, resources);
            var payloadJson = JsonSerializer.Serialize(payload, InworldJwtJsonContext.Default.InworldJwtRequestBody);

            using var request = new HttpRequestMessage(HttpMethod.Post, $"https://{host}/auth/v1/tokens/token:generate")
            {
                Content = new StringContent(payloadJson, Encoding.UTF8, "application/json"),
            };
            request.Headers.TryAddWithoutValidation(
                "Authorization",
                $"IW1-HMAC-SHA256 ApiKey={apiKey},DateTime={datetime},Nonce={nonce},Signature={signature}");

            using var response = await httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
            var body = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                throw new InworldJwtException(
                    $"Inworld token:generate returned {(int)response.StatusCode} {response.ReasonPhrase}: {body}");
            }

            var token = JsonSerializer.Deserialize(body, InworldJwtJsonContext.Default.InworldJwtToken)
                ?? throw new InworldJwtException($"Failed to deserialize Inworld token response: {body}");

            return token;
        }
        finally
        {
            ownedHttp?.Dispose();
        }
    }

    private static string GenerateNonce()
    {
        var bytes = new byte[6];
        RandomNumberGenerator.Fill(bytes);
        return System.Convert.ToHexStringLower(bytes).Substring(0, 11);
    }

    private static string ComputeSignature(
        string apiSecret,
        string datetime,
        string engineHost,
        string method,
        string nonce)
    {
        var key = Encoding.ASCII.GetBytes("IW1" + apiSecret);
        foreach (var param in new[] { datetime, engineHost, method, nonce })
        {
            key = HMACSHA256.HashData(key, Encoding.ASCII.GetBytes(param));
        }
        var sigBytes = HMACSHA256.HashData(key, Encoding.ASCII.GetBytes("iw1_request"));
        return System.Convert.ToHexStringLower(sigBytes);
    }
}

/// <summary>
/// Response from Inworld's <c>/auth/v1/tokens/token:generate</c> endpoint.
/// </summary>
public sealed record InworldJwtToken
{
    /// <summary>The JWT to use as <c>Authorization: Bearer &lt;token&gt;</c>.</summary>
    [JsonPropertyName("token")]
    public string Token { get; init; } = string.Empty;

    /// <summary>Token type — always <c>Bearer</c>.</summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "Bearer";

    /// <summary>ISO-8601 timestamp at which the token expires.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; init; }

    /// <summary>Session identifier associated with this token.</summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; init; }
}

internal sealed record InworldJwtRequestBody(
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("resources")] System.Collections.Generic.IReadOnlyList<string>? Resources);

/// <summary>
/// Thrown when Inworld's token-exchange endpoint returns a non-success response.
/// </summary>
[SuppressMessage("Design", "CA1032:Implement standard exception constructors", Justification = "Only message-only construction is meaningful for this exception.")]
public sealed class InworldJwtException : System.Exception
{
    /// <inheritdoc />
    public InworldJwtException(string message) : base(message) { }
}

[JsonSerializable(typeof(InworldJwtToken))]
[JsonSerializable(typeof(InworldJwtRequestBody))]
internal sealed partial class InworldJwtJsonContext : JsonSerializerContext;
