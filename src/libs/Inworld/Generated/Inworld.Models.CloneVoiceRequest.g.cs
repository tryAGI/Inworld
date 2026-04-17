
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneVoiceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// BCP-47-like language code used by Inworld voice APIs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.JsonConverters.LangCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inworld.LangCode LangCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceSamples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Inworld.VoiceSample> VoiceSamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Preprocessing applied to clone-voice samples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioProcessingConfig")]
        public global::Inworld.AudioProcessingConfig? AudioProcessingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceRequest" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="langCode">
        /// BCP-47-like language code used by Inworld voice APIs.
        /// </param>
        /// <param name="voiceSamples"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="audioProcessingConfig">
        /// Preprocessing applied to clone-voice samples.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloneVoiceRequest(
            string displayName,
            global::Inworld.LangCode langCode,
            global::System.Collections.Generic.IList<global::Inworld.VoiceSample> voiceSamples,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::Inworld.AudioProcessingConfig? audioProcessingConfig)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.LangCode = langCode;
            this.VoiceSamples = voiceSamples ?? throw new global::System.ArgumentNullException(nameof(voiceSamples));
            this.Description = description;
            this.Tags = tags;
            this.AudioProcessingConfig = audioProcessingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceRequest" /> class.
        /// </summary>
        public CloneVoiceRequest()
        {
        }
    }
}