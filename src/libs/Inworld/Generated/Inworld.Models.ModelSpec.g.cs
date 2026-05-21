
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputModalities")]
        public global::System.Collections.Generic.IList<global::Inworld.Modality>? InputModalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputModalities")]
        public global::System.Collections.Generic.IList<global::Inworld.Modality>? OutputModalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextLength")]
        public int? ContextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCompletionTokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedParameters")]
        public global::System.Collections.Generic.IList<string>? SupportedParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Inworld.ModelCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSpec" /> class.
        /// </summary>
        /// <param name="inputModalities"></param>
        /// <param name="outputModalities"></param>
        /// <param name="contextLength"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="supportedParameters"></param>
        /// <param name="capabilities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelSpec(
            global::System.Collections.Generic.IList<global::Inworld.Modality>? inputModalities,
            global::System.Collections.Generic.IList<global::Inworld.Modality>? outputModalities,
            int? contextLength,
            int? maxCompletionTokens,
            global::System.Collections.Generic.IList<string>? supportedParameters,
            global::Inworld.ModelCapabilities? capabilities)
        {
            this.InputModalities = inputModalities;
            this.OutputModalities = outputModalities;
            this.ContextLength = contextLength;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.SupportedParameters = supportedParameters;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSpec" /> class.
        /// </summary>
        public ModelSpec()
        {
        }

    }
}