
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Transcription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFinal")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordTimestamps")]
        public global::System.Collections.Generic.IList<global::Inworld.WordTimestamp>? WordTimestamps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcription" /> class.
        /// </summary>
        /// <param name="transcript"></param>
        /// <param name="isFinal"></param>
        /// <param name="wordTimestamps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Transcription(
            string? transcript,
            bool? isFinal,
            global::System.Collections.Generic.IList<global::Inworld.WordTimestamp>? wordTimestamps)
        {
            this.Transcript = transcript;
            this.IsFinal = isFinal;
            this.WordTimestamps = wordTimestamps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcription" /> class.
        /// </summary>
        public Transcription()
        {
        }
    }
}