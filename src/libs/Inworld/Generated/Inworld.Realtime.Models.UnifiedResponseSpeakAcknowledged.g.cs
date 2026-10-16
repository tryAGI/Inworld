
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseSpeakAcknowledged
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseSpeakAcknowledgedTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_event_id")]
        public string? RequestEventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Accepted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedMetadata? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedError? Error { get; set; }

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
        /// Initializes a new instance of the <see cref="UnifiedResponseSpeakAcknowledged" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="accepted"></param>
        /// <param name="type"></param>
        /// <param name="requestEventId"></param>
        /// <param name="responseId"></param>
        /// <param name="metadata"></param>
        /// <param name="error"></param>
        /// <param name="providerData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseSpeakAcknowledged(
            string eventId,
            bool accepted,
            global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedType type,
            string? requestEventId,
            string? responseId,
            global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedMetadata? metadata,
            global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedError? error,
            global::Inworld.Realtime.UnifiedProviderData? providerData)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.RequestEventId = requestEventId;
            this.Accepted = accepted;
            this.ResponseId = responseId;
            this.Metadata = metadata;
            this.Error = error;
            this.ProviderData = providerData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseSpeakAcknowledged" /> class.
        /// </summary>
        public UnifiedResponseSpeakAcknowledged()
        {
        }

    }
}