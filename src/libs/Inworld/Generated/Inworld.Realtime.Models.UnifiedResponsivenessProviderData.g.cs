
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponsivenessProviderData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_wait_timeout_ms")]
        public int? InitialWaitTimeoutMs { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("min_filler_gap_ms")]
        public int? MinFillerGapMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_initial_per_turn")]
        public int? MaxInitialPerTurn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_buffer_deltas")]
        public int? MaxBufferDeltas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_filler_on_first_assistant_reply")]
        public bool? EnableFillerOnFirstAssistantReply { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pause_text")]
        public string? PauseText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponsivenessProviderData" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="smallModel"></param>
        /// <param name="initialWaitTimeoutMs"></param>
        /// <param name="hardDeadlineMs"></param>
        /// <param name="historyTailItems"></param>
        /// <param name="temperature"></param>
        /// <param name="maxTokens"></param>
        /// <param name="minFillerGapMs"></param>
        /// <param name="maxInitialPerTurn"></param>
        /// <param name="maxBufferDeltas"></param>
        /// <param name="enableFillerOnFirstAssistantReply"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="pauseText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponsivenessProviderData(
            bool? enabled,
            string? smallModel,
            int? initialWaitTimeoutMs,
            int? hardDeadlineMs,
            int? historyTailItems,
            double? temperature,
            int? maxTokens,
            int? minFillerGapMs,
            int? maxInitialPerTurn,
            int? maxBufferDeltas,
            bool? enableFillerOnFirstAssistantReply,
            string? promptTemplate,
            string? pauseText)
        {
            this.Enabled = enabled;
            this.SmallModel = smallModel;
            this.InitialWaitTimeoutMs = initialWaitTimeoutMs;
            this.HardDeadlineMs = hardDeadlineMs;
            this.HistoryTailItems = historyTailItems;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.MinFillerGapMs = minFillerGapMs;
            this.MaxInitialPerTurn = maxInitialPerTurn;
            this.MaxBufferDeltas = maxBufferDeltas;
            this.EnableFillerOnFirstAssistantReply = enableFillerOnFirstAssistantReply;
            this.PromptTemplate = promptTemplate;
            this.PauseText = pauseText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponsivenessProviderData" /> class.
        /// </summary>
        public UnifiedResponsivenessProviderData()
        {
        }

    }
}