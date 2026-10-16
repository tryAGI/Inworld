
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedTextGenerationConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::Inworld.Realtime.UnifiedTextGenerationConfigReasoning? Reasoning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public double? TopP { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxNewTokens")]
        public int? MaxNewTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequencyPenalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presencePenalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTextGenerationConfig" /> class.
        /// </summary>
        /// <param name="reasoning"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="maxNewTokens"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedTextGenerationConfig(
            global::Inworld.Realtime.UnifiedTextGenerationConfigReasoning? reasoning,
            double? temperature,
            double? topP,
            int? maxNewTokens,
            double? frequencyPenalty,
            double? presencePenalty)
        {
            this.Reasoning = reasoning;
            this.Temperature = temperature;
            this.TopP = topP;
            this.MaxNewTokens = maxNewTokens;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTextGenerationConfig" /> class.
        /// </summary>
        public UnifiedTextGenerationConfig()
        {
        }

    }
}