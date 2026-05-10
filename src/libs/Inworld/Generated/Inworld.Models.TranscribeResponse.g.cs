
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscribeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::Inworld.Transcription? Transcription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Inworld.TranscribeUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeResponse" /> class.
        /// </summary>
        /// <param name="transcription"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscribeResponse(
            global::Inworld.Transcription? transcription,
            global::Inworld.TranscribeUsage? usage)
        {
            this.Transcription = transcription;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeResponse" /> class.
        /// </summary>
        public TranscribeResponse()
        {
        }

    }
}