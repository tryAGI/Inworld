
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_details")]
        public object? StatusDetails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOutputItem>? Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<string>? OutputModalities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<int?, string>))]
        public global::Inworld.Realtime.OneOf<int?, string>? MaxOutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public object? Audio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Inworld.Realtime.UnifiedResponseUsage? Usage { get; set; }

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
        /// Initializes a new instance of the <see cref="UnifiedResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="status"></param>
        /// <param name="statusDetails"></param>
        /// <param name="output"></param>
        /// <param name="conversationId"></param>
        /// <param name="outputModalities"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="audio"></param>
        /// <param name="instructions"></param>
        /// <param name="usage"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponse(
            string? id,
            string? @object,
            string? status,
            object? statusDetails,
            global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOutputItem>? output,
            string? conversationId,
            global::System.Collections.Generic.IList<string>? outputModalities,
            global::Inworld.Realtime.OneOf<int?, string>? maxOutputTokens,
            object? audio,
            string? instructions,
            global::Inworld.Realtime.UnifiedResponseUsage? usage,
            object? metadata)
        {
            this.Id = id;
            this.Object = @object;
            this.Status = status;
            this.StatusDetails = statusDetails;
            this.Output = output;
            this.ConversationId = conversationId;
            this.OutputModalities = outputModalities;
            this.MaxOutputTokens = maxOutputTokens;
            this.Audio = audio;
            this.Instructions = instructions;
            this.Usage = usage;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponse" /> class.
        /// </summary>
        public UnifiedResponse()
        {
        }

    }
}