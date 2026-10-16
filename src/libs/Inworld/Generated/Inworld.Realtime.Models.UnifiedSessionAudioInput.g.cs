
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedSessionAudioInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedAudioFormat>))]
        public global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedAudioFormat>? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise_reduction")]
        public global::Inworld.Realtime.UnifiedSessionAudioInputNoiseReduction? NoiseReduction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::Inworld.Realtime.UnifiedSessionAudioInputTranscription? Transcription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::Inworld.Realtime.UnifiedTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedSessionAudioInput" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="noiseReduction"></param>
        /// <param name="transcription"></param>
        /// <param name="turnDetection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedSessionAudioInput(
            global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedAudioFormat>? format,
            global::Inworld.Realtime.UnifiedSessionAudioInputNoiseReduction? noiseReduction,
            global::Inworld.Realtime.UnifiedSessionAudioInputTranscription? transcription,
            global::Inworld.Realtime.UnifiedTurnDetection? turnDetection)
        {
            this.Format = format;
            this.NoiseReduction = noiseReduction;
            this.Transcription = transcription;
            this.TurnDetection = turnDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedSessionAudioInput" /> class.
        /// </summary>
        public UnifiedSessionAudioInput()
        {
        }

    }
}