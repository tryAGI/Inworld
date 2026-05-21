
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidatedAudioSample
    {
        /// <summary>
        /// BCP-47-like language code used by Inworld voice APIs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.JsonConverters.LangCodeJsonConverter))]
        public global::Inworld.LangCode? LangCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::Inworld.ValidationMessage>? Warnings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Inworld.ValidationMessage>? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioData")]
        public byte[]? AudioData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatedAudioSample" /> class.
        /// </summary>
        /// <param name="langCode">
        /// BCP-47-like language code used by Inworld voice APIs.
        /// </param>
        /// <param name="warnings"></param>
        /// <param name="errors"></param>
        /// <param name="transcription"></param>
        /// <param name="audioData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidatedAudioSample(
            global::Inworld.LangCode? langCode,
            global::System.Collections.Generic.IList<global::Inworld.ValidationMessage>? warnings,
            global::System.Collections.Generic.IList<global::Inworld.ValidationMessage>? errors,
            string? transcription,
            byte[]? audioData)
        {
            this.LangCode = langCode;
            this.Warnings = warnings;
            this.Errors = errors;
            this.Transcription = transcription;
            this.AudioData = audioData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatedAudioSample" /> class.
        /// </summary>
        public ValidatedAudioSample()
        {
        }

    }
}