
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedTruncation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_ratio")]
        public double? RetentionRatio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_limits")]
        public global::Inworld.Realtime.UnifiedTruncationTokenLimits? TokenLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTruncation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="retentionRatio"></param>
        /// <param name="tokenLimits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedTruncation(
            string? type,
            double? retentionRatio,
            global::Inworld.Realtime.UnifiedTruncationTokenLimits? tokenLimits)
        {
            this.Type = type;
            this.RetentionRatio = retentionRatio;
            this.TokenLimits = tokenLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTruncation" /> class.
        /// </summary>
        public UnifiedTruncation()
        {
        }

    }
}