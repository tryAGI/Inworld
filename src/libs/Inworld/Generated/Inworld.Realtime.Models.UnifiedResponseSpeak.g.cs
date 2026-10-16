
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseSpeak
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseSpeakTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedResponseSpeakType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_uninterruptible")]
        public bool? ForceUninterruptible { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Inworld.Realtime.UnifiedResponseSpeakMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseSpeak" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="forceUninterruptible"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseSpeak(
            string text,
            global::Inworld.Realtime.UnifiedResponseSpeakType type,
            string? eventId,
            bool? forceUninterruptible,
            global::Inworld.Realtime.UnifiedResponseSpeakMetadata? metadata)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.ForceUninterruptible = forceUninterruptible;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseSpeak" /> class.
        /// </summary>
        public UnifiedResponseSpeak()
        {
        }

    }
}