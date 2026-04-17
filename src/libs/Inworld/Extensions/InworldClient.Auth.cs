#nullable enable

namespace Inworld;

/// <summary>
/// Inworld uses HTTP Basic auth with a Base64-encoded API key issued by the
/// Inworld Portal. The generated client is configured with an HTTP Bearer
/// security scheme, so requests would go out as "Authorization: Bearer &lt;key&gt;",
/// but Inworld expects "Authorization: Basic &lt;key&gt;". Rewrite the scheme on
/// every outgoing request via the per-client <c>PrepareRequest</c> partial hook.
/// </summary>
internal static class InworldAuthHook
{
    internal static void RewriteBearerToBasic(System.Net.Http.HttpRequestMessage request)
    {
        var auth = request.Headers.Authorization;
        if (auth is { Scheme: "Bearer", Parameter: { Length: > 0 } key })
        {
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", key);
        }
    }
}

public partial class InworldClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.RewriteBearerToBasic(request);
}

public partial class TextToSpeechClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.RewriteBearerToBasic(request);
}

public partial class SpeechToTextClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.RewriteBearerToBasic(request);
}

public partial class VoicesClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.RewriteBearerToBasic(request);
}

public partial class ModelsClient
{
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request) => InworldAuthHook.RewriteBearerToBasic(request);
}
