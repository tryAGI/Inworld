/*
order: 50
title: JWT Auth (Client-Side)
slug: jwt-auth

For client-side use (Blazor WebAssembly, browser, mobile) you should never embed
the long-lived Basic API key. Instead, exchange it for a short-lived JWT on a
trusted backend via `InworldJwt.GenerateAsync(key, secret)` and pass the JWT to
the client. The SDK auto-detects JWTs (Bearer) and skips the Basic rewrite.
*/

namespace Inworld.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_MintJwt()
    {
        //// Read the Inworld API key/secret from environment. The Basic key
        //// is Base64 of `key:secret`; for client-side usage we decode it into
        //// the pair before calling token:generate.
        var apiKey =
            Environment.GetEnvironmentVariable("INWORLD_JWT_KEY") is { Length: > 0 } k ? k :
            DecodeKeyPair(Environment.GetEnvironmentVariable("INWORLD_API_KEY")).key;

        var apiSecret =
            Environment.GetEnvironmentVariable("INWORLD_JWT_SECRET") is { Length: > 0 } s ? s :
            DecodeKeyPair(Environment.GetEnvironmentVariable("INWORLD_API_KEY")).secret;

        if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(apiSecret))
        {
            throw new AssertInconclusiveException("INWORLD_API_KEY (Basic Base64) or INWORLD_JWT_KEY + INWORLD_JWT_SECRET is required.");
        }

        //// Mint a short-lived Bearer JWT from the key+secret pair.
        var token = await InworldJwt.GenerateAsync(apiKey, apiSecret);

        //// The token is ready to pass to `new InworldClient(token.Token)` on the client.
        token.Token.Should().NotBeNullOrEmpty();
        token.Token.Should().StartWith("eyJ", because: "Inworld JWTs are RS/HS-signed JWS tokens that begin with the Base64url 'eyJ' prefix.");
        token.Type.Should().Be("Bearer");

        //// Use the JWT to call a REST endpoint. The SDK keeps the Bearer scheme for JWTs.
        using var client = new InworldClient(token.Token);
        var models = await client.Models.ListModelsAsync();
        models.Should().NotBeNull();
    }

    private static (string key, string secret) DecodeKeyPair(string? basicKey)
    {
        if (string.IsNullOrEmpty(basicKey))
        {
            return (string.Empty, string.Empty);
        }

        try
        {
            var decoded = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(basicKey));
            var idx = decoded.IndexOf(':', StringComparison.Ordinal);
            return idx > 0 ? (decoded[..idx], decoded[(idx + 1)..]) : (string.Empty, string.Empty);
        }
        catch (FormatException)
        {
            return (string.Empty, string.Empty);
        }
    }
}
