
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttTranscriptionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::Inworld.Realtime.SttTranscriptionData? Transcription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttTranscriptionResult" /> class.
        /// </summary>
        /// <param name="transcription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttTranscriptionResult(
            global::Inworld.Realtime.SttTranscriptionData? transcription)
        {
            this.Transcription = transcription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttTranscriptionResult" /> class.
        /// </summary>
        public SttTranscriptionResult()
        {
        }

    }
}