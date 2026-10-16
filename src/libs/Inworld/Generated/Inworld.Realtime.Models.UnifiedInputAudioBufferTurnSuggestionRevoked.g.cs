
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedInputAudioBufferTurnSuggestionRevoked
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferTurnSuggestionRevokedTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevokedType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterance_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UtteranceIndex { get; set; }

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
        /// Initializes a new instance of the <see cref="UnifiedInputAudioBufferTurnSuggestionRevoked" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="itemId"></param>
        /// <param name="utteranceIndex"></param>
        /// <param name="type"></param>
        /// <param name="providerData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedInputAudioBufferTurnSuggestionRevoked(
            string eventId,
            string itemId,
            int utteranceIndex,
            global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevokedType type,
            global::Inworld.Realtime.UnifiedProviderData? providerData)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.UtteranceIndex = utteranceIndex;
            this.ProviderData = providerData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedInputAudioBufferTurnSuggestionRevoked" /> class.
        /// </summary>
        public UnifiedInputAudioBufferTurnSuggestionRevoked()
        {
        }

    }
}