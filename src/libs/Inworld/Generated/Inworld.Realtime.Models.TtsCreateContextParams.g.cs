
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Model identifier, including `inworld-tts-2` for the latest research preview.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.StreamTimestampTypeJsonConverter))]
        public global::Inworld.Realtime.StreamTimestampType? TimestampType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.StreamApplyTextNormalizationJsonConverter))]
        public global::Inworld.Realtime.StreamApplyTextNormalization? ApplyTextNormalization { get; set; }

        /// <summary>
        /// Variation and expressiveness mode for Realtime TTS-2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveryMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.StreamDeliveryModeJsonConverter))]
        public global::Inworld.Realtime.StreamDeliveryMode? DeliveryMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoMode")]
        public bool? AutoMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestampTransportStrategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.StreamTimestampTransportStrategyJsonConverter))]
        public global::Inworld.Realtime.StreamTimestampTransportStrategy? TimestampTransportStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateContextParams" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="modelId">
        /// Model identifier, including `inworld-tts-2` for the latest research preview.
        /// </param>
        /// <param name="audioConfig">
        /// Audio output configuration for streaming TTS.
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="timestampType"></param>
        /// <param name="maxBufferDelayMs"></param>
        /// <param name="bufferCharThreshold"></param>
        /// <param name="applyTextNormalization"></param>
        /// <param name="deliveryMode">
        /// Variation and expressiveness mode for Realtime TTS-2.
        /// </param>
        /// <param name="autoMode"></param>
        /// <param name="timestampTransportStrategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateContextParams(
            string voiceId,
            string modelId,
            global::Inworld.Realtime.StreamAudioConfig? audioConfig,
            double? temperature,
            global::Inworld.Realtime.StreamTimestampType? timestampType,
            int? maxBufferDelayMs,
            int? bufferCharThreshold,
            global::Inworld.Realtime.StreamApplyTextNormalization? applyTextNormalization,
            global::Inworld.Realtime.StreamDeliveryMode? deliveryMode,
            bool? autoMode,
            global::Inworld.Realtime.StreamTimestampTransportStrategy? timestampTransportStrategy)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.AudioConfig = audioConfig;
            this.Temperature = temperature;
            this.TimestampType = timestampType;
            this.MaxBufferDelayMs = maxBufferDelayMs;
            this.BufferCharThreshold = bufferCharThreshold;
            this.ApplyTextNormalization = applyTextNormalization;
            this.DeliveryMode = deliveryMode;
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