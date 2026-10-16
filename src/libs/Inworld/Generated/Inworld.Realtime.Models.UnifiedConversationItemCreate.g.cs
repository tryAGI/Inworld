
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedConversationItemCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemCreateTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedConversationItemCreateType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inworld.Realtime.UnifiedConversationItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedConversationItemCreate" /> class.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="previousItemId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedConversationItemCreate(
            global::Inworld.Realtime.UnifiedConversationItem item,
            global::Inworld.Realtime.UnifiedConversationItemCreateType type,
            string? eventId,
            string? previousItemId)
        {
            this.Type = type;
            this.EventId = eventId;
            this.PreviousItemId = previousItemId;
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedConversationItemCreate" /> class.
        /// </summary>
        public UnifiedConversationItemCreate()
        {
        }

    }
}