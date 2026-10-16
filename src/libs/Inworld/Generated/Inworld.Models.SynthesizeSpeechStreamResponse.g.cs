
#nullable enable

namespace Inworld
{
    /// <summary>
    /// One NDJSON message. Inspect error before using result.
    /// </summary>
    public sealed partial class SynthesizeSpeechStreamResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::Inworld.SynthesizeSpeechResponse? Result { get; set; }

        /// <summary>
        /// Standard gRPC-style error envelope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Inworld.RpcStatus? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeSpeechStreamResponse" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="error">
        /// Standard gRPC-style error envelope.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SynthesizeSpeechStreamResponse(
            global::Inworld.SynthesizeSpeechResponse? result,
            global::Inworld.RpcStatus? error)
        {
            this.Result = result;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeSpeechStreamResponse" /> class.
        /// </summary>
        public SynthesizeSpeechStreamResponse()
        {
        }

    }
}