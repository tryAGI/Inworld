
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
        /// Model identifier, e.g. `inworld-tts-1.5` or `inworld-tts-1.5-max`.
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
        /// Model identifier, e.g. `inworld-tts-1.5` or `inworld-tts-1.5-max`.
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
            global::Inworld.ApplyTextNormalization? applyTextNormalization)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.AudioConfig = audioConfig;
            this.Temperature = temperature;
            this.TimestampType = timestampType;
            this.ApplyTextNormalization = applyTextNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeSpeechRequest" /> class.
        /// </summary>
        public SynthesizeSpeechRequest()
        {
        }

    }
}