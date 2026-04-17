
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsSendTextParams
    {
        /// <summary>
        /// Text to synthesize. Maximum 1000 characters per chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Optional empty object; if set, triggers flush after text is enqueued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flush_context")]
        public object? FlushContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSendTextParams" /> class.
        /// </summary>
        /// <param name="text">
        /// Text to synthesize. Maximum 1000 characters per chunk.
        /// </param>
        /// <param name="flushContext">
        /// Optional empty object; if set, triggers flush after text is enqueued.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsSendTextParams(
            string? text,
            object? flushContext)
        {
            this.Text = text;
            this.FlushContext = flushContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSendTextParams" /> class.
        /// </summary>
        public TtsSendTextParams()
        {
        }
    }
}