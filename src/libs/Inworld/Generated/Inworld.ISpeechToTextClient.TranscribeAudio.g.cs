#nullable enable

namespace Inworld
{
    public partial interface ISpeechToTextClient
    {
        /// <summary>
        /// Transcribe audio<br/>
        /// Transcribe a complete audio file using the configured STT model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.TranscribeResponse> TranscribeAudioAsync(

            global::Inworld.TranscribeRequest request,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe audio<br/>
        /// Transcribe a complete audio file using the configured STT model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.AutoSDKHttpResponse<global::Inworld.TranscribeResponse>> TranscribeAudioAsResponseAsync(

            global::Inworld.TranscribeRequest request,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe audio<br/>
        /// Transcribe a complete audio file using the configured STT model.
        /// </summary>
        /// <param name="transcribeConfig">
        /// Configuration for STT transcription.
        /// </param>
        /// <param name="audioData">
        /// Inline audio payload.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.TranscribeResponse> TranscribeAudioAsync(
            global::Inworld.TranscribeConfig transcribeConfig,
            global::Inworld.AudioData audioData,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}