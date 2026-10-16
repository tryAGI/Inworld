
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseAudioDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseAudioDeltaTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedResponseAudioDeltaType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Delta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerData")]
        public global::Inworld.Realtime.UnifiedProviderData? ProviderData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_info")]
        public global::Inworld.Realtime.UnifiedTimestampInfo? TimestampInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseAudioDelta" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="responseId"></param>
        /// <param name="delta"></param>
        /// <param name="type"></param>
        /// <param name="itemId"></param>
        /// <param name="outputIndex"></param>
        /// <param name="contentIndex"></param>
        /// <param name="providerData"></param>
        /// <param name="timestampInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseAudioDelta(
            string eventId,
            string responseId,
            byte[] delta,
            global::Inworld.Realtime.UnifiedResponseAudioDeltaType type,
            string? itemId,
            int? outputIndex,
            int? contentIndex,
            global::Inworld.Realtime.UnifiedProviderData? providerData,
            global::Inworld.Realtime.UnifiedTimestampInfo? timestampInfo)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.ProviderData = providerData;
            this.TimestampInfo = timestampInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseAudioDelta" /> class.
        /// </summary>
        public UnifiedResponseAudioDelta()
        {
        }

    }
}