#nullable enable

namespace Inworld
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List available LLM models<br/>
        /// List all LLM models supported by the Inworld LLM Router, including<br/>
        /// provider, pricing, modalities, capabilities, and context length.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Inworld.ListModelsResponse> ListModelsAsync(
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}