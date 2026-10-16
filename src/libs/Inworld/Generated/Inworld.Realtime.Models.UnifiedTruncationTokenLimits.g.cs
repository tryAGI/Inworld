
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedTruncationTokenLimits
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_instructions")]
        public int? PostInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTruncationTokenLimits" /> class.
        /// </summary>
        /// <param name="postInstructions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedTruncationTokenLimits(
            int? postInstructions)
        {
            this.PostInstructions = postInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTruncationTokenLimits" /> class.
        /// </summary>
        public UnifiedTruncationTokenLimits()
        {
        }

    }
}