
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Token/character usage metadata.
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// Characters processed by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processedCharactersCount")]
        public int? ProcessedCharactersCount { get; set; }

        /// <summary>
        /// Model used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="processedCharactersCount">
        /// Characters processed by the model.
        /// </param>
        /// <param name="modelId">
        /// Model used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usage(
            int? processedCharactersCount,
            string? modelId)
        {
            this.ProcessedCharactersCount = processedCharactersCount;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }

    }
}