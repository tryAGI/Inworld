
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DesignVoiceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langCode")]
        public string? LangCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewVoices")]
        public global::System.Collections.Generic.IList<global::Inworld.PreviewVoice>? PreviewVoices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignVoiceResponse" /> class.
        /// </summary>
        /// <param name="langCode"></param>
        /// <param name="previewVoices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DesignVoiceResponse(
            string? langCode,
            global::System.Collections.Generic.IList<global::Inworld.PreviewVoice>? previewVoices)
        {
            this.LangCode = langCode;
            this.PreviewVoices = previewVoices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignVoiceResponse" /> class.
        /// </summary>
        public DesignVoiceResponse()
        {
        }
    }
}