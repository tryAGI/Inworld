/*
order: 40
title: MEAI Tools
slug: meai-tools

Using Inworld endpoints as AIFunction tools with any Microsoft.Extensions.AI IChatClient.
*/

namespace Inworld.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_CreateTools()
    {
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools from the Inworld client.
        var synthesizeTool = client.AsSynthesizeSpeechTool();
        var listVoicesTool = client.AsListVoicesTool();
        var listModelsTool = client.AsListModelsTool();
        var designVoiceTool = client.AsDesignVoiceTool();

        //// Verify all tools are created with the expected names.
        synthesizeTool.Name.Should().Be("Inworld_SynthesizeSpeech");
        listVoicesTool.Name.Should().Be("Inworld_ListVoices");
        listModelsTool.Name.Should().Be("Inworld_ListModels");
        designVoiceTool.Name.Should().Be("Inworld_DesignVoice");

        //// These tools can be passed to any IChatClient for function calling.
        var tools = new[] { synthesizeTool, listVoicesTool, listModelsTool, designVoiceTool };
        tools.Should().HaveCount(4);
    }
}
