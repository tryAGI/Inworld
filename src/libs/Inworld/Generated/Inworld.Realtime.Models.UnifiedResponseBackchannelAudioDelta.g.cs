
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseBackchannelAudioDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseBackchannelAudioDeltaTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDeltaType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Delta { get; set; }

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
        /// Initializes a new instance of the <see cref="UnifiedResponseBackchannelAudioDelta" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="backchannelId"></param>
        /// <param name="delta"></param>
        /// <param name="type"></param>
        /// <param name="providerData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseBackchannelAudioDelta(
            string eventId,
            string backchannelId,
            byte[] delta,
            global::Inworld.Realtime.UnifiedResponseBackchannelAudioDeltaType type,
            global::Inworld.Realtime.UnifiedProviderData? providerData)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.BackchannelId = backchannelId ?? throw new global::System.ArgumentNullException(nameof(backchannelId));
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.ProviderData = providerData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseBackchannelAudioDelta" /> class.
        /// </summary>
        public UnifiedResponseBackchannelAudioDelta()
        {
        }

    }
}