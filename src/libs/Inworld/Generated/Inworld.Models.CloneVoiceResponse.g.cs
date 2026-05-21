
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneVoiceResponse
    {
        /// <summary>
        /// A voice available for TTS synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public global::Inworld.Voice? Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioSamplesValidated")]
        public global::System.Collections.Generic.IList<global::Inworld.ValidatedAudioSample>? AudioSamplesValidated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceResponse" /> class.
        /// </summary>
        /// <param name="voice">
        /// A voice available for TTS synthesis.
        /// </param>
        /// <param name="audioSamplesValidated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloneVoiceResponse(
            global::Inworld.Voice? voice,
            global::System.Collections.Generic.IList<global::Inworld.ValidatedAudioSample>? audioSamplesValidated)
        {
            this.Voice = voice;
            this.AudioSamplesValidated = audioSamplesValidated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceResponse" /> class.
        /// </summary>
        public CloneVoiceResponse()
        {
        }

    }
}