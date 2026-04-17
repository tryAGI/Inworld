
#nullable enable

namespace Inworld
{
    /// <summary>
    /// A single audio sample used to clone a voice.
    /// </summary>
    public sealed partial class VoiceSample
    {
        /// <summary>
        /// Base64-encoded audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] AudioData { get; set; }

        /// <summary>
        /// Optional transcription of the audio sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSample" /> class.
        /// </summary>
        /// <param name="audioData">
        /// Base64-encoded audio bytes.
        /// </param>
        /// <param name="transcription">
        /// Optional transcription of the audio sample.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSample(
            byte[] audioData,
            string? transcription)
        {
            this.AudioData = audioData ?? throw new global::System.ArgumentNullException(nameof(audioData));
            this.Transcription = transcription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSample" /> class.
        /// </summary>
        public VoiceSample()
        {
        }
    }
}