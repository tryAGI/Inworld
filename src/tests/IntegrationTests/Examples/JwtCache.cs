/*
order: 55
title: JWT Cache
slug: jwt-cache

`InworldJwtCache` keeps one JWT per `(apiKey, resources)` pair in process and
refreshes it ~60s before `expirationTime`. Use it on Blazor/ASP.NET Core
backends to avoid hitting `/auth/v1/tokens/token:generate` on every request.
*/

namespace Inworld.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_JwtCache_ReusesTokenUntilRefresh()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("INWORLD_JWT_KEY") is { Length: > 0 } k ? k :
            DecodeKeyPair(Environment.GetEnvironmentVariable("INWORLD_API_KEY")).key;
        var apiSecret =
            Environment.GetEnvironmentVariable("INWORLD_JWT_SECRET") is { Length: > 0 } s ? s :
            DecodeKeyPair(Environment.GetEnvironmentVariable("INWORLD_API_KEY")).secret;

        if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(apiSecret))
        {
            throw new AssertInconclusiveException("INWORLD_API_KEY (or INWORLD_JWT_KEY + INWORLD_JWT_SECRET) is required.");
        }

        //// Create one cache per (apiKey, resources) and reuse it across requests.
        using var cache = new InworldJwtCache(apiKey, apiSecret);

        //// First call mints a fresh JWT.
        var first = await cache.GetAsync();
        first.Token.Should().NotBeNullOrEmpty();
        first.Token.Should().StartWith("eyJ");

        //// Second call returns the same cached token (no second round trip).
        var second = await cache.GetAsync();
        second.Token.Should().Be(first.Token);

        //// After invalidate the cache mints a new token.
        cache.Invalidate();
        var third = await cache.GetAsync();
        third.Token.Should().NotBeNullOrEmpty();
        // Inworld may issue identical JWTs within the same clock second — don't
        // rely on the token value changing; just verify we got one back.
    }
}
