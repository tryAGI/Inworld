
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedSessionAudioInputTranscription
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        public global::System.Collections.Generic.IList<string>? Prompts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedSessionAudioInputTranscription" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="language"></param>
        /// <param name="prompt"></param>
        /// <param name="prompts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedSessionAudioInputTranscription(
            string? model,
            string? language,
            string? prompt,
            global::System.Collections.Generic.IList<string>? prompts)
        {
            this.Model = model;
            this.Language = language;
            this.Prompt = prompt;
            this.Prompts = prompts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedSessionAudioInputTranscription" /> class.
        /// </summary>
        public UnifiedSessionAudioInputTranscription()
        {
        }

    }
}