
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsSendText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_text")]
        public global::Inworld.Realtime.TtsSendTextParams? SendText { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsSendText" /> class.
        /// </summary>
        /// <param name="sendText"></param>
        /// <param name="contextId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsSendText(
            global::Inworld.Realtime.TtsSendTextParams? sendText,
            string? contextId)
        {
            this.SendText = sendText;
            this.ContextId = contextId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSendText" /> class.
        /// </summary>
        public TtsSendText()
        {
        }

    }
}