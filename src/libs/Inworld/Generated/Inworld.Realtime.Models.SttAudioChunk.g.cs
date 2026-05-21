
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttAudioChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_chunk")]
        public global::Inworld.Realtime.SttAudioChunkData? AudioChunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttAudioChunk" /> class.
        /// </summary>
        /// <param name="audioChunk"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttAudioChunk(
            global::Inworld.Realtime.SttAudioChunkData? audioChunk)
        {
            this.AudioChunk = audioChunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttAudioChunk" /> class.
        /// </summary>
        public SttAudioChunk()
        {
        }

    }
}