
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricing
    {
        /// <summary>
        /// Cost per million prompt tokens (or equivalent).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public double? Prompt { get; set; }

        /// <summary>
        /// Cost per million completion tokens (or equivalent).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        public double? Completion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricing" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Cost per million prompt tokens (or equivalent).
        /// </param>
        /// <param name="completion">
        /// Cost per million completion tokens (or equivalent).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricing(
            double? prompt,
            double? completion)
        {
            this.Prompt = prompt;
            this.Completion = completion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricing" /> class.
        /// </summary>
        public ModelPricing()
        {
        }
    }
}