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
        /// <param name="text">
        /// The text to synthesize. Maximum 2,000 characters.
        /// </param>
        /// <param name="voiceId">
        /// Voice identifier.
        /// </param>
        /// <param name="modelId">
        /// Model identifier, e.g. `inworld-tts-1.5` or `inworld-tts-1.5-max`.
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
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}