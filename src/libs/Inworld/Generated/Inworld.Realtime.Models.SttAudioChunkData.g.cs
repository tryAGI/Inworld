
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttAudioChunkData
    {
        /// <summary>
        /// Base64-encoded audio bytes whose encoding matches transcribe_config.audioEncoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public byte[]? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttAudioChunkData" /> class.
        /// </summary>
        /// <param name="content">
        /// Base64-encoded audio bytes whose encoding matches transcribe_config.audioEncoding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttAudioChunkData(
            byte[]? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttAudioChunkData" /> class.
        /// </summary>
        public SttAudioChunkData()
        {
        }
    }
}