
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedSession
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<string>? OutputModalities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

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
        public global::Inworld.Realtime.UnifiedSessionAudio? Audio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedSessionTool>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedToolChoice>))]
        public global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedToolChoice>? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedTruncation>))]
        public global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedTruncation>? Truncation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedTracing>))]
        public global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedTracing>? Tracing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerData")]
        public global::Inworld.Realtime.UnifiedProviderData? ProviderData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_generation_config")]
        public global::Inworld.Realtime.UnifiedTextGenerationConfig? TextGenerationConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedSession" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="instructions"></param>
        /// <param name="outputModalities"></param>
        /// <param name="temperature"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="audio"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="truncation"></param>
        /// <param name="tracing"></param>
        /// <param name="include"></param>
        /// <param name="prompt"></param>
        /// <param name="providerData"></param>
        /// <param name="textGenerationConfig"></param>
        /// <param name="expiresAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedSession(
            string? @object,
            string? type,
            string? id,
            string? model,
            string? instructions,
            global::System.Collections.Generic.IList<string>? outputModalities,
            double? temperature,
            global::Inworld.Realtime.OneOf<int?, string>? maxOutputTokens,
            global::Inworld.Realtime.UnifiedSessionAudio? audio,
            global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedSessionTool>? tools,
            global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedToolChoice>? toolChoice,
            global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedTruncation>? truncation,
            global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedTracing>? tracing,
            global::System.Collections.Generic.IList<string>? include,
            string? prompt,
            global::Inworld.Realtime.UnifiedProviderData? providerData,
            global::Inworld.Realtime.UnifiedTextGenerationConfig? textGenerationConfig,
            long? expiresAt)
        {
            this.Object = @object;
            this.Type = type;
            this.Id = id;
            this.Model = model;
            this.Instructions = instructions;
            this.OutputModalities = outputModalities;
            this.Temperature = temperature;
            this.MaxOutputTokens = maxOutputTokens;
            this.Audio = audio;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Truncation = truncation;
            this.Tracing = tracing;
            this.Include = include;
            this.Prompt = prompt;
            this.ProviderData = providerData;
            this.TextGenerationConfig = textGenerationConfig;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedSession" /> class.
        /// </summary>
        public UnifiedSession()
        {
        }

    }
}