
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedInputAudioBufferAppend
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferAppendTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedInputAudioBufferAppendType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedInputAudioBufferAppend" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedInputAudioBufferAppend(
            byte[] audio,
            global::Inworld.Realtime.UnifiedInputAudioBufferAppendType type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedInputAudioBufferAppend" /> class.
        /// </summary>
        public UnifiedInputAudioBufferAppend()
        {
        }

    }
}