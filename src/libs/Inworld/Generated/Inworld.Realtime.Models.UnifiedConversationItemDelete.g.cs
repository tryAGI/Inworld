
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedConversationItemDelete
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemDeleteTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedConversationItemDeleteType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedConversationItemDelete" /> class.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedConversationItemDelete(
            string itemId,
            global::Inworld.Realtime.UnifiedConversationItemDeleteType type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedConversationItemDelete" /> class.
        /// </summary>
        public UnifiedConversationItemDelete()
        {
        }

    }
}