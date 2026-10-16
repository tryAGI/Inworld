
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_token_details")]
        public global::Inworld.Realtime.UnifiedResponseUsageInputTokenDetails? InputTokenDetails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_token_details")]
        public global::Inworld.Realtime.UnifiedResponseUsageOutputTokenDetails? OutputTokenDetails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::Inworld.Realtime.UnifiedResponseUsageLlm? Llm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::Inworld.Realtime.UnifiedResponseUsageTts? Tts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        public global::Inworld.Realtime.UnifiedResponseUsageStt? Stt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseUsage" /> class.
        /// </summary>
        /// <param name="totalTokens"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="inputTokenDetails"></param>
        /// <param name="outputTokenDetails"></param>
        /// <param name="llm"></param>
        /// <param name="tts"></param>
        /// <param name="stt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseUsage(
            int? totalTokens,
            int? inputTokens,
            int? outputTokens,
            global::Inworld.Realtime.UnifiedResponseUsageInputTokenDetails? inputTokenDetails,
            global::Inworld.Realtime.UnifiedResponseUsageOutputTokenDetails? outputTokenDetails,
            global::Inworld.Realtime.UnifiedResponseUsageLlm? llm,
            global::Inworld.Realtime.UnifiedResponseUsageTts? tts,
            global::Inworld.Realtime.UnifiedResponseUsageStt? stt)
        {
            this.TotalTokens = totalTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.InputTokenDetails = inputTokenDetails;
            this.OutputTokenDetails = outputTokenDetails;
            this.Llm = llm;
            this.Tts = tts;
            this.Stt = stt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseUsage" /> class.
        /// </summary>
        public UnifiedResponseUsage()
        {
        }

    }
}