#nullable enable

namespace Inworld
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Delete voice
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteVoiceAsync(
            string voiceId,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete voice
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.AutoSDKHttpResponse<string>> DeleteVoiceAsResponseAsync(
            string voiceId,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}