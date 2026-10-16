#nullable enable

namespace Inworld;

public partial class TextToSpeechClient
{
    // The wire response is NDJSON, but Inworld documents application/json for Accept.
    // Keep the NDJSON media type in the spec so AutoSDK generates an incremental reader.
    partial void PrepareSynthesizeSpeechStreamRequest(
        System.Net.Http.HttpClient httpClient,
        System.Net.Http.HttpRequestMessage httpRequestMessage,
        SynthesizeSpeechRequest request)
    {
        httpRequestMessage.Headers.Accept.Clear();
        httpRequestMessage.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    }
}
