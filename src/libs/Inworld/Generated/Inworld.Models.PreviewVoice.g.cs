
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewText")]
        public string? PreviewText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewAudio")]
        public byte[]? PreviewAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewVoice" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="previewText"></param>
        /// <param name="previewAudio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewVoice(
            string? voiceId,
            string? previewText,
            byte[]? previewAudio)
        {
            this.VoiceId = voiceId;
            this.PreviewText = previewText;
            this.PreviewAudio = previewAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewVoice" /> class.
        /// </summary>
        public PreviewVoice()
        {
        }

    }
}