
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedTextGenerationConfigReasoning
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public string? Effort { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public bool? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTextGenerationConfigReasoning" /> class.
        /// </summary>
        /// <param name="effort"></param>
        /// <param name="maxTokens"></param>
        /// <param name="exclude"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedTextGenerationConfigReasoning(
            string? effort,
            int? maxTokens,
            bool? exclude)
        {
            this.Effort = effort;
            this.MaxTokens = maxTokens;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTextGenerationConfigReasoning" /> class.
        /// </summary>
        public UnifiedTextGenerationConfigReasoning()
        {
        }

    }
}