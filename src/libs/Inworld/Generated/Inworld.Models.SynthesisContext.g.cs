
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Prior synthesis requests used to improve continuity for short or ambiguous text. Context text is not billed.
    /// </summary>
    public sealed partial class SynthesisContext
    {
        /// <summary>
        /// Earlier request texts in synthesis order. Their combined text must not exceed 2,000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousRequests")]
        public global::System.Collections.Generic.IList<global::Inworld.PreviousSynthesisRequest>? PreviousRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesisContext" /> class.
        /// </summary>
        /// <param name="previousRequests">
        /// Earlier request texts in synthesis order. Their combined text must not exceed 2,000 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SynthesisContext(
            global::System.Collections.Generic.IList<global::Inworld.PreviousSynthesisRequest>? previousRequests)
        {
            this.PreviousRequests = previousRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesisContext" /> class.
        /// </summary>
        public SynthesisContext()
        {
        }

    }
}