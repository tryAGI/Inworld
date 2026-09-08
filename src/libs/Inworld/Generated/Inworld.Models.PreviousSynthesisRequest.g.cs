
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Text from an earlier synthesis request in the same conversation.
    /// </summary>
    public sealed partial class PreviousSynthesisRequest
    {
        /// <summary>
        /// Text synthesized in the earlier request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviousSynthesisRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// Text synthesized in the earlier request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviousSynthesisRequest(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviousSynthesisRequest" /> class.
        /// </summary>
        public PreviousSynthesisRequest()
        {
        }

    }
}