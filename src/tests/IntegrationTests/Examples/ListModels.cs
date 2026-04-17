/*
order: 30
title: List Models
slug: list-models

Inworld's LLM Router exposes models from multiple providers. Use this call to discover which ones are available with their capabilities and pricing.
*/

namespace Inworld.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListModels()
    {
        using var client = GetAuthenticatedClient();

        //// Fetch all supported LLM models along with their modalities, context length, and pricing.
        var response = await client.Models.ListModelsAsync();

        response.Should().NotBeNull();
        response.Models.Should().NotBeNull();
    }
}
