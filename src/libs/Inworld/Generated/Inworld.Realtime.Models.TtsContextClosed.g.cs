
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsContextClosed
    {
        /// <summary>
        /// |
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::Inworld.Realtime.TtsResultEnvelope? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsContextClosed" /> class.
        /// </summary>
        /// <param name="result">
        /// |
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsContextClosed(
            global::Inworld.Realtime.TtsResultEnvelope? result)
        {
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsContextClosed" /> class.
        /// </summary>
        public TtsContextClosed()
        {
        }

    }
}