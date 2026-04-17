
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inworld.LangCode LangCode { get; set; }

        /// <summary>
        /// English description of the desired voice. 30–250 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("designPrompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DesignPrompt { get; set; }

        /// <summary>
        /// Text to speak in the generated preview. Should produce 1–15 seconds of audio.
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
        /// <param name="langCode">
        /// BCP-47-like language code used by Inworld voice APIs.
        /// </param>
        /// <param name="designPrompt">
        /// English description of the desired voice. 30–250 characters.
        /// </param>
        /// <param name="previewText">
        /// Text to speak in the generated preview. Should produce 1–15 seconds of audio.
        /// </param>
        /// <param name="voiceDesignConfig">
        /// Tuning parameters for voice design.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DesignVoiceRequest(
            global::Inworld.LangCode langCode,
            string designPrompt,
            string previewText,
            global::Inworld.VoiceDesignConfig? voiceDesignConfig)
        {
            this.LangCode = langCode;
            this.DesignPrompt = designPrompt ?? throw new global::System.ArgumentNullException(nameof(designPrompt));
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