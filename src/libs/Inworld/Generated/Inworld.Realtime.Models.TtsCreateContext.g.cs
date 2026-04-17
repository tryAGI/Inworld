
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsCreateContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create")]
        public global::Inworld.Realtime.TtsCreateContextParams? Create { get; set; }

        /// <summary>
        /// Optional stable context id; server generates one when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextId")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateContext" /> class.
        /// </summary>
        /// <param name="create"></param>
        /// <param name="contextId">
        /// Optional stable context id; server generates one when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateContext(
            global::Inworld.Realtime.TtsCreateContextParams? create,
            string? contextId)
        {
            this.Create = create;
            this.ContextId = contextId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateContext" /> class.
        /// </summary>
        public TtsCreateContext()
        {
        }
    }
}