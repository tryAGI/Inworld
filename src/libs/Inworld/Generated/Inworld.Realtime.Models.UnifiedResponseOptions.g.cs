
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseOptions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public string? Conversation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<string>? OutputModalities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<int?, string>))]
        public global::Inworld.Realtime.OneOf<int?, string>? MaxOutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedToolChoice>))]
        public global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedToolChoice>? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOptionsTool>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseOptions" /> class.
        /// </summary>
        /// <param name="conversation"></param>
        /// <param name="outputModalities"></param>
        /// <param name="instructions"></param>
        /// <param name="voice"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="toolChoice"></param>
        /// <param name="tools"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseOptions(
            string? conversation,
            global::System.Collections.Generic.IList<string>? outputModalities,
            string? instructions,
            string? voice,
            global::Inworld.Realtime.OneOf<int?, string>? maxOutputTokens,
            global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedToolChoice>? toolChoice,
            global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOptionsTool>? tools,
            object? metadata)
        {
            this.Conversation = conversation;
            this.OutputModalities = outputModalities;
            this.Instructions = instructions;
            this.Voice = voice;
            this.MaxOutputTokens = maxOutputTokens;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseOptions" /> class.
        /// </summary>
        public UnifiedResponseOptions()
        {
        }

    }
}