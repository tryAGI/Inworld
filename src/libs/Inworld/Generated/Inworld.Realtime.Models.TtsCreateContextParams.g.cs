
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsCreateContextParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Audio output configuration for streaming TTS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioConfig")]
        public global::Inworld.Realtime.StreamAudioConfig? AudioConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestampType")]
        public string? TimestampType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxBufferDelayMs")]
        public int? MaxBufferDelayMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bufferCharThreshold")]
        public int? BufferCharThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyTextNormalization")]
        public string? ApplyTextNormalization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoMode")]
        public bool? AutoMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestampTransportStrategy")]
        public string? TimestampTransportStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateContextParams" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="modelId"></param>
        /// <param name="audioConfig">
        /// Audio output configuration for streaming TTS.
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="timestampType"></param>
        /// <param name="maxBufferDelayMs"></param>
        /// <param name="bufferCharThreshold"></param>
        /// <param name="applyTextNormalization"></param>
        /// <param name="autoMode"></param>
        /// <param name="timestampTransportStrategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateContextParams(
            string? voiceId,
            string? modelId,
            global::Inworld.Realtime.StreamAudioConfig? audioConfig,
            double? temperature,
            string? timestampType,
            int? maxBufferDelayMs,
            int? bufferCharThreshold,
            string? applyTextNormalization,
            bool? autoMode,
            string? timestampTransportStrategy)
        {
            this.VoiceId = voiceId;
            this.ModelId = modelId;
            this.AudioConfig = audioConfig;
            this.Temperature = temperature;
            this.TimestampType = timestampType;
            this.MaxBufferDelayMs = maxBufferDelayMs;
            this.BufferCharThreshold = bufferCharThreshold;
            this.ApplyTextNormalization = applyTextNormalization;
            this.AutoMode = autoMode;
            this.TimestampTransportStrategy = timestampTransportStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateContextParams" /> class.
        /// </summary>
        public TtsCreateContextParams()
        {
        }

    }
}