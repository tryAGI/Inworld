
#nullable enable

namespace Inworld
{
    /// <summary>
    /// A voice available for TTS synthesis.
    /// </summary>
    public sealed partial class Voice
    {
        /// <summary>
        /// Voice identifier in the form `{workspace}__{voice}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Resource name `workspaces/{workspace}/voices/{voice}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Human-readable voice name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Optional description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// BCP-47-like language code used by Inworld voice APIs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.JsonConverters.LangCodeJsonConverter))]
        public global::Inworld.LangCode? LangCode { get; set; }

        /// <summary>
        /// Free-form tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Origin of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.JsonConverters.VoiceSourceJsonConverter))]
        public global::Inworld.VoiceSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice identifier in the form `{workspace}__{voice}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// Resource name `workspaces/{workspace}/voices/{voice}`.
        /// </param>
        /// <param name="displayName">
        /// Human-readable voice name.
        /// </param>
        /// <param name="description">
        /// Optional description.
        /// </param>
        /// <param name="langCode">
        /// BCP-47-like language code used by Inworld voice APIs.
        /// </param>
        /// <param name="tags">
        /// Free-form tags.
        /// </param>
        /// <param name="source">
        /// Origin of the voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Voice(
            string? voiceId,
            string? name,
            string? displayName,
            string? description,
            global::Inworld.LangCode? langCode,
            global::System.Collections.Generic.IList<string>? tags,
            global::Inworld.VoiceSource? source)
        {
            this.VoiceId = voiceId;
            this.Name = name;
            this.DisplayName = displayName;
            this.Description = description;
            this.LangCode = langCode;
            this.Tags = tags;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        public Voice()
        {
        }
    }
}