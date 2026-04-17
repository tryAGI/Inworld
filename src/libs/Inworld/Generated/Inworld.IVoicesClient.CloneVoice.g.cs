#nullable enable

namespace Inworld
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Clone voice<br/>
        /// Create an Instant Voice Clone (IVC) from one or more short audio<br/>
        /// samples. The returned voice can be used in TTS synthesis.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.CloneVoiceResponse> CloneVoiceAsync(

            global::Inworld.CloneVoiceRequest request,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone voice<br/>
        /// Create an Instant Voice Clone (IVC) from one or more short audio<br/>
        /// samples. The returned voice can be used in TTS synthesis.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="langCode">
        /// BCP-47-like language code used by Inworld voice APIs.
        /// </param>
        /// <param name="voiceSamples"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="audioProcessingConfig">
        /// Preprocessing applied to clone-voice samples.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.CloneVoiceResponse> CloneVoiceAsync(
            string displayName,
            global::Inworld.LangCode langCode,
            global::System.Collections.Generic.IList<global::Inworld.VoiceSample> voiceSamples,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Inworld.AudioProcessingConfig? audioProcessingConfig = default,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}