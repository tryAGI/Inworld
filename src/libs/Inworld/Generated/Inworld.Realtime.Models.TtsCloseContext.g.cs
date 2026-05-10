
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsCloseContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("close_context")]
        public object? CloseContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextId")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCloseContext" /> class.
        /// </summary>
        /// <param name="closeContext"></param>
        /// <param name="contextId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCloseContext(
            object? closeContext,
            string? contextId)
        {
            this.CloseContext = closeContext;
            this.ContextId = contextId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCloseContext" /> class.
        /// </summary>
        public TtsCloseContext()
        {
        }

    }
}