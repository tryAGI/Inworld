
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedInputAudioBufferTurnSuggestion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferTurnSuggestionTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Probability { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trailing_silence_ms")]
        public double? TrailingSilenceMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration_ms")]
        public double? AudioDurationMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_ms")]
        public double? InferenceMs { get; set; }

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
        /// Initializes a new instance of the <see cref="UnifiedInputAudioBufferTurnSuggestion" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="itemId"></param>
        /// <param name="utteranceIndex"></param>
        /// <param name="probability"></param>
        /// <param name="type"></param>
        /// <param name="trailingSilenceMs"></param>
        /// <param name="audioDurationMs"></param>
        /// <param name="inferenceMs"></param>
        /// <param name="providerData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedInputAudioBufferTurnSuggestion(
            string eventId,
            string itemId,
            int utteranceIndex,
            double probability,
            global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionType type,
            double? trailingSilenceMs,
            double? audioDurationMs,
            double? inferenceMs,
            global::Inworld.Realtime.UnifiedProviderData? providerData)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.UtteranceIndex = utteranceIndex;
            this.Probability = probability;
            this.TrailingSilenceMs = trailingSilenceMs;
            this.AudioDurationMs = audioDurationMs;
            this.InferenceMs = inferenceMs;
            this.ProviderData = providerData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedInputAudioBufferTurnSuggestion" /> class.
        /// </summary>
        public UnifiedInputAudioBufferTurnSuggestion()
        {
        }

    }
}