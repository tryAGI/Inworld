
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseCancel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseCancelTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedResponseCancelType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseCancel" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="responseId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseCancel(
            global::Inworld.Realtime.UnifiedResponseCancelType type,
            string? eventId,
            string? responseId)
        {
            this.Type = type;
            this.EventId = eventId;
            this.ResponseId = responseId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseCancel" /> class.
        /// </summary>
        public UnifiedResponseCancel()
        {
        }

    }
}