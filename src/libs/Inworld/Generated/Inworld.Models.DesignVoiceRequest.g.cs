
#nullable enable

namespace Inworld
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DesignVoiceRequest
    {
        /// <summary>
        /// BCP-47-like language code used by Inworld voice APIs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.JsonConverters.LangCodeJsonConverter))]
        public global::Inworld.LangCode? LangCode { get; set; }

        /// <summary>
        /// BCP-47 language or locale (for example `en-US`, `en-GB`, or `vi`). Omit to auto-detect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// English description of the desired voice. Up to 1,000 characters; descriptions under 30 characters rarely produce useful results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("designPrompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DesignPrompt { get; set; }

        /// <summary>
        /// How the voice-design prompt is interpreted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("designPromptMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.JsonConverters.DesignPromptModeJsonConverter))]
        public global::Inworld.DesignPromptMode? DesignPromptMode { get; set; }

        /// <summary>
        /// Text to speak in the generated preview. Must produce 1–30 seconds of audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewText { get; set; }

        /// <summary>
        /// Tuning parameters for voice design.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceDesignConfig")]
        public global::Inworld.VoiceDesignConfig? VoiceDesignConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignVoiceRequest" /> class.
        /// </summary>
        /// <param name="designPrompt">
        /// English description of the desired voice. Up to 1,000 characters; descriptions under 30 characters rarely produce useful results.
        /// </param>
        /// <param name="previewText">
        /// Text to speak in the generated preview. Must produce 1–30 seconds of audio.
        /// </param>
        /// <param name="langCode">
        /// BCP-47-like language code used by Inworld voice APIs.
        /// </param>
        /// <param name="languageCode">
        /// BCP-47 language or locale (for example `en-US`, `en-GB`, or `vi`). Omit to auto-detect.
        /// </param>
        /// <param name="designPromptMode">
        /// How the voice-design prompt is interpreted.
        /// </param>
        /// <param name="voiceDesignConfig">
        /// Tuning parameters for voice design.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DesignVoiceRequest(
            string designPrompt,
            string previewText,
            global::Inworld.LangCode? langCode,
            string? languageCode,
            global::Inworld.DesignPromptMode? designPromptMode,
            global::Inworld.VoiceDesignConfig? voiceDesignConfig)
        {
            this.LangCode = langCode;
            this.LanguageCode = languageCode;
            this.DesignPrompt = designPrompt ?? throw new global::System.ArgumentNullException(nameof(designPrompt));
            this.DesignPromptMode = designPromptMode;
            this.PreviewText = previewText ?? throw new global::System.ArgumentNullException(nameof(previewText));
            this.VoiceDesignConfig = voiceDesignConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignVoiceRequest" /> class.
        /// </summary>
        public DesignVoiceRequest()
        {
        }

    }
}