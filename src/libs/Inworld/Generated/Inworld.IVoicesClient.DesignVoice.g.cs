#nullable enable

namespace Inworld
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Design voice<br/>
        /// Generate candidate voice previews from a text description. Previews<br/>
        /// can be promoted to a persistent voice via Publish Voice.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.DesignVoiceResponse> DesignVoiceAsync(

            global::Inworld.DesignVoiceRequest request,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Design voice<br/>
        /// Generate candidate voice previews from a text description. Previews<br/>
        /// can be promoted to a persistent voice via Publish Voice.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.AutoSDKHttpResponse<global::Inworld.DesignVoiceResponse>> DesignVoiceAsResponseAsync(

            global::Inworld.DesignVoiceRequest request,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Design voice<br/>
        /// Generate candidate voice previews from a text description. Previews<br/>
        /// can be promoted to a persistent voice via Publish Voice.
        /// </summary>
        /// <param name="langCode">
        /// BCP-47-like language code used by Inworld voice APIs.
        /// </param>
        /// <param name="languageCode">
        /// BCP-47 language or locale (for example `en-US`, `en-GB`, or `vi`). Omit to auto-detect.
        /// </param>
        /// <param name="designPrompt">
        /// English description of the desired voice. Up to 1,000 characters; descriptions under 30 characters rarely produce useful results.
        /// </param>
        /// <param name="designPromptMode">
        /// How the voice-design prompt is interpreted.
        /// </param>
        /// <param name="previewText">
        /// Text to speak in the generated preview. Must produce 1–30 seconds of audio.
        /// </param>
        /// <param name="voiceDesignConfig">
        /// Tuning parameters for voice design.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.DesignVoiceResponse> DesignVoiceAsync(
            string designPrompt,
            string previewText,
            global::Inworld.LangCode? langCode = default,
            string? languageCode = default,
            global::Inworld.DesignPromptMode? designPromptMode = default,
            global::Inworld.VoiceDesignConfig? voiceDesignConfig = default,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}