
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedConversationItemTruncate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemTruncateTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedConversationItemTruncateType Type { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioEndMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedConversationItemTruncate" /> class.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="contentIndex"></param>
        /// <param name="audioEndMs"></param>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedConversationItemTruncate(
            string itemId,
            int contentIndex,
            int audioEndMs,
            global::Inworld.Realtime.UnifiedConversationItemTruncateType type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.ContentIndex = contentIndex;
            this.AudioEndMs = audioEndMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedConversationItemTruncate" /> class.
        /// </summary>
        public UnifiedConversationItemTruncate()
        {
        }

    }
}