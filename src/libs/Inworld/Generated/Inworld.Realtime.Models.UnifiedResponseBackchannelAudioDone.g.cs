
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseBackchannelAudioDone
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseBackchannelAudioDoneTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDoneType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backchannel_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackchannelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phrase")]
        public string? Phrase { get; set; }

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
        /// Initializes a new instance of the <see cref="UnifiedResponseBackchannelAudioDone" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="backchannelId"></param>
        /// <param name="type"></param>
        /// <param name="phrase"></param>
        /// <param name="providerData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseBackchannelAudioDone(
            string eventId,
            string backchannelId,
            global::Inworld.Realtime.UnifiedResponseBackchannelAudioDoneType type,
            string? phrase,
            global::Inworld.Realtime.UnifiedProviderData? providerData)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.BackchannelId = backchannelId ?? throw new global::System.ArgumentNullException(nameof(backchannelId));
            this.Phrase = phrase;
            this.ProviderData = providerData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseBackchannelAudioDone" /> class.
        /// </summary>
        public UnifiedResponseBackchannelAudioDone()
        {
        }

    }
}