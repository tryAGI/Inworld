
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionCalling")]
        public bool? FunctionCalling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webSearch")]
        public bool? WebSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public bool? Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptCaching")]
        public bool? PromptCaching { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseSchema")]
        public bool? ResponseSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vision")]
        public bool? Vision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCapabilities" /> class.
        /// </summary>
        /// <param name="functionCalling"></param>
        /// <param name="webSearch"></param>
        /// <param name="reasoning"></param>
        /// <param name="promptCaching"></param>
        /// <param name="responseSchema"></param>
        /// <param name="vision"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelCapabilities(
            bool? functionCalling,
            bool? webSearch,
            bool? reasoning,
            bool? promptCaching,
            bool? responseSchema,
            bool? vision)
        {
            this.FunctionCalling = functionCalling;
            this.WebSearch = webSearch;
            this.Reasoning = reasoning;
            this.PromptCaching = promptCaching;
            this.ResponseSchema = responseSchema;
            this.Vision = vision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCapabilities" /> class.
        /// </summary>
        public ModelCapabilities()
        {
        }

    }
}