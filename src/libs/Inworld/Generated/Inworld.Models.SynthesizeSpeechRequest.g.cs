
#nullable enable

namespace Inworld
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SynthesizeSpeechRequest
    {
        /// <summary>
        /// The text to synthesize. Maximum 2,000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Voice identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Model identifier. Use `inworld-tts-2` for flagship quality and steering, or `inworld-tts-2-flash` for the lowest latency and cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Audio output configuration for TTS synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioConfig")]
        public global::Inworld.AudioConfig? AudioConfig { get; set; }

        /// <summary>
        /// Sampling temperature in the range (0, 2]. Defaults to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Timestamp granularity returned alongside TTS audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestampType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.JsonConverters.TimestampTypeJsonConverter))]
        public global::Inworld.TimestampType? TimestampType { get; set; }

        /// <summary>
        /// Whether text normalization is applied before synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyTextNormalization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.JsonConverters.ApplyTextNormalizationJsonConverter))]
        public global::Inworld.ApplyTextNormalization? ApplyTextNormalization { get; set; }

        /// <summary>
        /// Variation and expressiveness mode for Realtime TTS-2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveryMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.JsonConverters.DeliveryModeJsonConverter))]
        public global::Inworld.DeliveryMode? DeliveryMode { get; set; }

        /// <summary>
        /// BCP-47 language tag (for example `en-US`, `fr-FR`, or `ja-JP`). Omit to auto-detect the input language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// English speaking-style direction for the whole request. Supported by `inworld-tts-2`; inline bracketed instructions can override it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Apply denoising to reduce background noise and synthesis artifacts.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhanceGeneration")]
        public bool? EnhanceGeneration { get; set; }

        /// <summary>
        /// Prior synthesis requests used to improve continuity for short or ambiguous text. Context text is not billed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synthesisContext")]
        public global::Inworld.SynthesisContext? SynthesisContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeSpeechRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to synthesize. Maximum 2,000 characters.
        /// </param>
        /// <param name="voiceId">
        /// Voice identifier.
        /// </param>
        /// <param name="modelId">
        /// Model identifier. Use `inworld-tts-2` for flagship quality and steering, or `inworld-tts-2-flash` for the lowest latency and cost.
        /// </param>
        /// <param name="audioConfig">
        /// Audio output configuration for TTS synthesis.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature in the range (0, 2]. Defaults to 1.0.
        /// </param>
        /// <param name="timestampType">
        /// Timestamp granularity returned alongside TTS audio.
        /// </param>
        /// <param name="applyTextNormalization">
        /// Whether text normalization is applied before synthesis.
        /// </param>
        /// <param name="deliveryMode">
        /// Variation and expressiveness mode for Realtime TTS-2.
        /// </param>
        /// <param name="language">
        /// BCP-47 language tag (for example `en-US`, `fr-FR`, or `ja-JP`). Omit to auto-detect the input language.
        /// </param>
        /// <param name="instruction">
        /// English speaking-style direction for the whole request. Supported by `inworld-tts-2`; inline bracketed instructions can override it.
        /// </param>
        /// <param name="enhanceGeneration">
        /// Apply denoising to reduce background noise and synthesis artifacts.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="synthesisContext">
        /// Prior synthesis requests used to improve continuity for short or ambiguous text. Context text is not billed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SynthesizeSpeechRequest(
            string text,
            string voiceId,
            string modelId,
            global::Inworld.AudioConfig? audioConfig,
            double? temperature,
            global::Inworld.TimestampType? timestampType,
            global::Inworld.ApplyTextNormalization? applyTextNormalization,
            global::Inworld.DeliveryMode? deliveryMode,
            string? language,
            string? instruction,
            bool? enhanceGeneration,
            global::Inworld.SynthesisContext? synthesisContext)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.AudioConfig = audioConfig;
            this.Temperature = temperature;
            this.TimestampType = timestampType;
            this.ApplyTextNormalization = applyTextNormalization;
            this.DeliveryMode = deliveryMode;
            this.Language = language;
            this.Instruction = instruction;
            this.EnhanceGeneration = enhanceGeneration;
            this.SynthesisContext = synthesisContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeSpeechRequest" /> class.
        /// </summary>
        public SynthesizeSpeechRequest()
        {
        }

    }
}