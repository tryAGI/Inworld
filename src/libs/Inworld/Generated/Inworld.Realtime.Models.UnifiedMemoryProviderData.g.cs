
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedMemoryProviderData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_interval")]
        public int? TurnInterval { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_memory_length")]
        public int? MaxMemoryLength { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_transcript_items")]
        public int? MaxTranscriptItems { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_facts")]
        public int? MaxFacts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_after_summarize")]
        public bool? TrimAfterSummarize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedMemoryProviderData" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="turnInterval"></param>
        /// <param name="maxMemoryLength"></param>
        /// <param name="maxTranscriptItems"></param>
        /// <param name="maxFacts"></param>
        /// <param name="trimAfterSummarize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedMemoryProviderData(
            bool? enabled,
            int? turnInterval,
            int? maxMemoryLength,
            int? maxTranscriptItems,
            int? maxFacts,
            bool? trimAfterSummarize)
        {
            this.Enabled = enabled;
            this.TurnInterval = turnInterval;
            this.MaxMemoryLength = maxMemoryLength;
            this.MaxTranscriptItems = maxTranscriptItems;
            this.MaxFacts = maxFacts;
            this.TrimAfterSummarize = trimAfterSummarize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedMemoryProviderData" /> class.
        /// </summary>
        public UnifiedMemoryProviderData()
        {
        }

    }
}