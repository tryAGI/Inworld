
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedBackchannelProviderData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("small_model")]
        public string? SmallModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_interval_ms")]
        public int? EvalIntervalMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_speech_ms")]
        public int? MinSpeechMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_gap_ms")]
        public int? MinGapMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_per_turn")]
        public int? MaxPerTurn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hard_deadline_ms")]
        public int? HardDeadlineMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_tail_items")]
        public int? HistoryTailItems { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_gain")]
        public double? VolumeGain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_pause")]
        public bool? RequirePause { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_phrases")]
        public global::System.Collections.Generic.IList<string>? AllowedPhrases { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_fire_probability")]
        public double? RuleFireProbability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBackchannelProviderData" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="smallModel"></param>
        /// <param name="evalIntervalMs"></param>
        /// <param name="minSpeechMs"></param>
        /// <param name="minGapMs"></param>
        /// <param name="maxPerTurn"></param>
        /// <param name="hardDeadlineMs"></param>
        /// <param name="historyTailItems"></param>
        /// <param name="temperature"></param>
        /// <param name="maxTokens"></param>
        /// <param name="volumeGain"></param>
        /// <param name="requirePause"></param>
        /// <param name="allowedPhrases"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="ruleFireProbability"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedBackchannelProviderData(
            bool? enabled,
            string? smallModel,
            int? evalIntervalMs,
            int? minSpeechMs,
            int? minGapMs,
            int? maxPerTurn,
            int? hardDeadlineMs,
            int? historyTailItems,
            double? temperature,
            int? maxTokens,
            double? volumeGain,
            bool? requirePause,
            global::System.Collections.Generic.IList<string>? allowedPhrases,
            string? promptTemplate,
            double? ruleFireProbability)
        {
            this.Enabled = enabled;
            this.SmallModel = smallModel;
            this.EvalIntervalMs = evalIntervalMs;
            this.MinSpeechMs = minSpeechMs;
            this.MinGapMs = minGapMs;
            this.MaxPerTurn = maxPerTurn;
            this.HardDeadlineMs = hardDeadlineMs;
            this.HistoryTailItems = historyTailItems;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.VolumeGain = volumeGain;
            this.RequirePause = requirePause;
            this.AllowedPhrases = allowedPhrases;
            this.PromptTemplate = promptTemplate;
            this.RuleFireProbability = ruleFireProbability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBackchannelProviderData" /> class.
        /// </summary>
        public UnifiedBackchannelProviderData()
        {
        }

    }
}