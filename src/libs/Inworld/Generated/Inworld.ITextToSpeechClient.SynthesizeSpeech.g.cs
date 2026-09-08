#nullable enable

namespace Inworld
{
    public partial interface ITextToSpeechClient
    {
        /// <summary>
        /// Synthesize speech<br/>
        /// Synthesize speech from text using the specified voice and model.<br/>
        /// Returns the full audio payload once generation completes. Maximum<br/>
        /// input is 2,000 characters; maximum output is 16 MB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.SynthesizeSpeechResponse> SynthesizeSpeechAsync(

            global::Inworld.SynthesizeSpeechRequest request,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech<br/>
        /// Synthesize speech from text using the specified voice and model.<br/>
        /// Returns the full audio payload once generation completes. Maximum<br/>
        /// input is 2,000 characters; maximum output is 16 MB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.AutoSDKHttpResponse<global::Inworld.SynthesizeSpeechResponse>> SynthesizeSpeechAsResponseAsync(

            global::Inworld.SynthesizeSpeechRequest request,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech<br/>
        /// Synthesize speech from text using the specified voice and model.<br/>
        /// Returns the full audio payload once generation completes. Maximum<br/>
        /// input is 2,000 characters; maximum output is 16 MB.
        /// </summary>
        /// <param name="text">
        /// The text to synthesize. Maximum 2,000 characters.
        /// </param>
        /// <param name="voiceId">
        /// Voice identifier.
        /// </param>
        /// <param name="modelId">
        /// Model identifier. Use `inworld-tts-2` for flagship quality and steering, or `inworld-tts-2-flash` for the lowest latency and cost.
        /// </param>
        /// <param name="audioConfig">
        /// Audio output configuration for TTS synthesis.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature in the range (0, 2]. Defaults to 1.0.
        /// </param>
        /// <param name="timestampType">
        /// Timestamp granularity returned alongside TTS audio.
        /// </param>
        /// <param name="applyTextNormalization">
        /// Whether text normalization is applied before synthesis.
        /// </param>
        /// <param name="deliveryMode">
        /// Variation and expressiveness mode for Realtime TTS-2.
        /// </param>
        /// <param name="language">
        /// BCP-47 language tag (for example `en-US`, `fr-FR`, or `ja-JP`). Omit to auto-detect the input language.
        /// </param>
        /// <param name="instruction">
        /// English speaking-style direction for the whole request. Supported by `inworld-tts-2`; inline bracketed instructions can override it.
        /// </param>
        /// <param name="enhanceGeneration">
        /// Apply denoising to reduce background noise and synthesis artifacts.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="synthesisContext">
        /// Prior synthesis requests used to improve continuity for short or ambiguous text. Context text is not billed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.SynthesizeSpeechResponse> SynthesizeSpeechAsync(
            string text,
            string voiceId,
            string modelId,
            global::Inworld.AudioConfig? audioConfig = default,
            double? temperature = default,
            global::Inworld.TimestampType? timestampType = default,
            global::Inworld.ApplyTextNormalization? applyTextNormalization = default,
            global::Inworld.DeliveryMode? deliveryMode = default,
            string? language = default,
            string? instruction = default,
            bool? enhanceGeneration = default,
            global::Inworld.SynthesisContext? synthesisContext = default,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}