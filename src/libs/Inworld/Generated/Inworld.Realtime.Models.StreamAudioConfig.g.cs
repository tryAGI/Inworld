
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// Audio output configuration for streaming TTS.
    /// </summary>
    public sealed partial class StreamAudioConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioEncoding")]
        public string? AudioEncoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRateHertz")]
        public int? SampleRateHertz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitRate")]
        public int? BitRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakingRate")]
        public double? SpeakingRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamAudioConfig" /> class.
        /// </summary>
        /// <param name="audioEncoding"></param>
        /// <param name="sampleRateHertz"></param>
        /// <param name="bitRate"></param>
        /// <param name="speakingRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamAudioConfig(
            string? audioEncoding,
            int? sampleRateHertz,
            int? bitRate,
            double? speakingRate)
        {
            this.AudioEncoding = audioEncoding;
            this.SampleRateHertz = sampleRateHertz;
            this.BitRate = bitRate;
            this.SpeakingRate = speakingRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamAudioConfig" /> class.
        /// </summary>
        public StreamAudioConfig()
        {
        }

    }
}