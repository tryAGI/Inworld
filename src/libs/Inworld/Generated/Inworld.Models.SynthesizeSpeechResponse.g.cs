
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SynthesizeSpeechResponse
    {
        /// <summary>
        /// Base64-encoded audio bytes. Includes container headers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioContent")]
        public byte[]? AudioContent { get; set; }

        /// <summary>
        /// Token/character usage metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Inworld.Usage? Usage { get; set; }

        /// <summary>
        /// Timestamp information for synthesized audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestampInfo")]
        public global::Inworld.TimestampInfo? TimestampInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeSpeechResponse" /> class.
        /// </summary>
        /// <param name="audioContent">
        /// Base64-encoded audio bytes. Includes container headers.
        /// </param>
        /// <param name="usage">
        /// Token/character usage metadata.
        /// </param>
        /// <param name="timestampInfo">
        /// Timestamp information for synthesized audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SynthesizeSpeechResponse(
            byte[]? audioContent,
            global::Inworld.Usage? usage,
            global::Inworld.TimestampInfo? timestampInfo)
        {
            this.AudioContent = audioContent;
            this.Usage = usage;
            this.TimestampInfo = timestampInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeSpeechResponse" /> class.
        /// </summary>
        public SynthesizeSpeechResponse()
        {
        }

    }
}