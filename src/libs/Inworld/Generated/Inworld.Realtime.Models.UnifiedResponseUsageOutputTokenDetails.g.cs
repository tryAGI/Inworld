
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseUsageOutputTokenDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseUsageOutputTokenDetails" /> class.
        /// </summary>
        /// <param name="textTokens"></param>
        /// <param name="audioTokens"></param>
        /// <param name="reasoningTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseUsageOutputTokenDetails(
            int? textTokens,
            int? audioTokens,
            int? reasoningTokens)
        {
            this.TextTokens = textTokens;
            this.AudioTokens = audioTokens;
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseUsageOutputTokenDetails" /> class.
        /// </summary>
        public UnifiedResponseUsageOutputTokenDetails()
        {
        }

    }
}