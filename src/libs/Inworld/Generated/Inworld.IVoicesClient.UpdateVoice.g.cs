#nullable enable

namespace Inworld
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Update voice<br/>
        /// Update editable voice metadata (display name, description, tags).
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.Voice> UpdateVoiceAsync(
            string voiceId,

            global::Inworld.UpdateVoiceRequest request,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update voice<br/>
        /// Update editable voice metadata (display name, description, tags).
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.AutoSDKHttpResponse<global::Inworld.Voice>> UpdateVoiceAsResponseAsync(
            string voiceId,

            global::Inworld.UpdateVoiceRequest request,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update voice<br/>
        /// Update editable voice metadata (display name, description, tags).
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.Voice> UpdateVoiceAsync(
            string voiceId,
            string? displayName = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}