
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Audio output configuration for TTS synthesis.
    /// </summary>
    public sealed partial class AudioConfig
    {
        /// <summary>
        /// Audio container/encoding. Defaults to MP3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioEncoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.JsonConverters.AudioEncodingJsonConverter))]
        public global::Inworld.AudioEncoding? AudioEncoding { get; set; }

        /// <summary>
        /// Sample rate in Hz. Range [8000, 48000]. Defaults to 48000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRateHertz")]
        public int? SampleRateHertz { get; set; }

        /// <summary>
        /// Bit rate for compressed encodings. Defaults to 128000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitRate")]
        public int? BitRate { get; set; }

        /// <summary>
        /// Speaking rate. Range [0.5, 1.5]. Defaults to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakingRate")]
        public double? SpeakingRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioConfig" /> class.
        /// </summary>
        /// <param name="audioEncoding">
        /// Audio container/encoding. Defaults to MP3.
        /// </param>
        /// <param name="sampleRateHertz">
        /// Sample rate in Hz. Range [8000, 48000]. Defaults to 48000.
        /// </param>
        /// <param name="bitRate">
        /// Bit rate for compressed encodings. Defaults to 128000.
        /// </param>
        /// <param name="speakingRate">
        /// Speaking rate. Range [0.5, 1.5]. Defaults to 1.0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioConfig(
            global::Inworld.AudioEncoding? audioEncoding,
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
        /// Initializes a new instance of the <see cref="AudioConfig" /> class.
        /// </summary>
        public AudioConfig()
        {
        }
    }
}