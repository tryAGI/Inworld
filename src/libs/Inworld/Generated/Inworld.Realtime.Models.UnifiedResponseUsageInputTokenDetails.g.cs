
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseUsageInputTokenDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_tokens")]
        public int? CacheWriteTokens { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseUsageInputTokenDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens"></param>
        /// <param name="cacheWriteTokens"></param>
        /// <param name="textTokens"></param>
        /// <param name="audioTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseUsageInputTokenDetails(
            int? cachedTokens,
            int? cacheWriteTokens,
            int? textTokens,
            int? audioTokens)
        {
            this.CachedTokens = cachedTokens;
            this.CacheWriteTokens = cacheWriteTokens;
            this.TextTokens = textTokens;
            this.AudioTokens = audioTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseUsageInputTokenDetails" /> class.
        /// </summary>
        public UnifiedResponseUsageInputTokenDetails()
        {
        }

    }
}