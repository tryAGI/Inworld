
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsAudioChunkData
    {
        /// <summary>
        /// Base64-encoded audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioContent")]
        public byte[]? AudioContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Inworld.Realtime.TtsStreamUsage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestampInfo")]
        public global::Inworld.Realtime.TtsTimestampInfo? TimestampInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAudioChunkData" /> class.
        /// </summary>
        /// <param name="audioContent">
        /// Base64-encoded audio bytes.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="timestampInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAudioChunkData(
            byte[]? audioContent,
            global::Inworld.Realtime.TtsStreamUsage? usage,
            global::Inworld.Realtime.TtsTimestampInfo? timestampInfo)
        {
            this.AudioContent = audioContent;
            this.Usage = usage;
            this.TimestampInfo = timestampInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAudioChunkData" /> class.
        /// </summary>
        public TtsAudioChunkData()
        {
        }
    }
}