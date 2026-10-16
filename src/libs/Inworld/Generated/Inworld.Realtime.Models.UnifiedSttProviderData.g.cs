
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedSttProviderData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_profile")]
        public bool? VoiceProfile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_of_turn_confidence_threshold")]
        public double? EndOfTurnConfidenceThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vad_threshold")]
        public double? VadThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_end_of_turn_silence")]
        public int? MinEndOfTurnSilence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_turn_silence")]
        public int? MaxTurnSilence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedSttProviderData" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="voiceProfile"></param>
        /// <param name="endOfTurnConfidenceThreshold"></param>
        /// <param name="vadThreshold"></param>
        /// <param name="minEndOfTurnSilence"></param>
        /// <param name="maxTurnSilence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedSttProviderData(
            string? prompt,
            bool? voiceProfile,
            double? endOfTurnConfidenceThreshold,
            double? vadThreshold,
            int? minEndOfTurnSilence,
            int? maxTurnSilence)
        {
            this.Prompt = prompt;
            this.VoiceProfile = voiceProfile;
            this.EndOfTurnConfidenceThreshold = endOfTurnConfidenceThreshold;
            this.VadThreshold = vadThreshold;
            this.MinEndOfTurnSilence = minEndOfTurnSilence;
            this.MaxTurnSilence = maxTurnSilence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedSttProviderData" /> class.
        /// </summary>
        public UnifiedSttProviderData()
        {
        }

    }
}