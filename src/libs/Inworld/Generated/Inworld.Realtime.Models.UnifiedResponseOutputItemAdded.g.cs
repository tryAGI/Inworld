
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseOutputItemAdded
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputItemAddedTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedResponseOutputItemAddedType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inworld.Realtime.UnifiedConversationItem Item { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerData")]
        public global::Inworld.Realtime.UnifiedProviderData? ProviderData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseOutputItemAdded" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="responseId"></param>
        /// <param name="item"></param>
        /// <param name="type"></param>
        /// <param name="outputIndex"></param>
        /// <param name="providerData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseOutputItemAdded(
            string eventId,
            string responseId,
            global::Inworld.Realtime.UnifiedConversationItem item,
            global::Inworld.Realtime.UnifiedResponseOutputItemAddedType type,
            int? outputIndex,
            global::Inworld.Realtime.UnifiedProviderData? providerData)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.OutputIndex = outputIndex;
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.ProviderData = providerData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseOutputItemAdded" /> class.
        /// </summary>
        public UnifiedResponseOutputItemAdded()
        {
        }

    }
}