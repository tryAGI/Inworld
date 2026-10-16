
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedInputAudioBufferClear
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferClearTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedInputAudioBufferClearType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedInputAudioBufferClear" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedInputAudioBufferClear(
            global::Inworld.Realtime.UnifiedInputAudioBufferClearType type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedInputAudioBufferClear" /> class.
        /// </summary>
        public UnifiedInputAudioBufferClear()
        {
        }

    }
}