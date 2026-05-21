
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscribeRequest
    {
        /// <summary>
        /// Configuration for STT transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribeConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inworld.TranscribeConfig TranscribeConfig { get; set; }

        /// <summary>
        /// Inline audio payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inworld.AudioData AudioData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeRequest" /> class.
        /// </summary>
        /// <param name="transcribeConfig">
        /// Configuration for STT transcription.
        /// </param>
        /// <param name="audioData">
        /// Inline audio payload.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscribeRequest(
            global::Inworld.TranscribeConfig transcribeConfig,
            global::Inworld.AudioData audioData)
        {
            this.TranscribeConfig = transcribeConfig ?? throw new global::System.ArgumentNullException(nameof(transcribeConfig));
            this.AudioData = audioData ?? throw new global::System.ArgumentNullException(nameof(audioData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeRequest" /> class.
        /// </summary>
        public TranscribeRequest()
        {
        }

    }
}