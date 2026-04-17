/*
order: 20
title: List Voices
slug: list-voices

Discover voices available to your Inworld workspace.
*/

namespace Inworld.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListVoices()
    {
        using var client = GetAuthenticatedClient();

        //// List all voices in the workspace. Pass the `languages` parameter to filter by language code.
        var response = await client.Voices.ListVoicesAsync();

        response.Should().NotBeNull();
        response.Voices.Should().NotBeNull();
    }
}
