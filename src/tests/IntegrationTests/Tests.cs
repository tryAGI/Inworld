namespace Inworld.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static InworldClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("INWORLD_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("INWORLD_API_KEY environment variable is not found.");

        var client = new InworldClient(apiKey);
        
        return client;
    }
}
