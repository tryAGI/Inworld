
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Configuration for STT transcription.
    /// </summary>
    public sealed partial class TranscribeConfig
    {
        /// <summary>
        /// Provider-qualified model ID, e.g. `inworld/inworld-stt-v1`,<br/>
        /// `groq/whisper-large-v3`, or `assemblyai/universal-2`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Audio encoding used for STT input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioEncoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.JsonConverters.SttAudioEncodingJsonConverter))]
        public global::Inworld.SttAudioEncoding? AudioEncoding { get; set; }

        /// <summary>
        /// BCP-47 language tag (e.g. `en-US`). Omit for auto-detect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Sample rate in Hz. Defaults to 16000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRateHertz")]
        public int? SampleRateHertz { get; set; }

        /// <summary>
        /// Number of audio channels. Defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfChannels")]
        public int? NumberOfChannels { get; set; }

        /// <summary>
        /// Include per-word start/end timestamps in the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeWordTimestamps")]
        public bool? IncludeWordTimestamps { get; set; }

        /// <summary>
        /// Optional voice profiling (speaker characteristics detection).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceProfileConfig")]
        public global::Inworld.VoiceProfileConfig? VoiceProfileConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeConfig" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Provider-qualified model ID, e.g. `inworld/inworld-stt-v1`,<br/>
        /// `groq/whisper-large-v3`, or `assemblyai/universal-2`.
        /// </param>
        /// <param name="audioEncoding">
        /// Audio encoding used for STT input.
        /// </param>
        /// <param name="language">
        /// BCP-47 language tag (e.g. `en-US`). Omit for auto-detect.
        /// </param>
        /// <param name="sampleRateHertz">
        /// Sample rate in Hz. Defaults to 16000.
        /// </param>
        /// <param name="numberOfChannels">
        /// Number of audio channels. Defaults to 1.
        /// </param>
        /// <param name="includeWordTimestamps">
        /// Include per-word start/end timestamps in the result.
        /// </param>
        /// <param name="voiceProfileConfig">
        /// Optional voice profiling (speaker characteristics detection).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscribeConfig(
            string? modelId,
            global::Inworld.SttAudioEncoding? audioEncoding,
            string? language,
            int? sampleRateHertz,
            int? numberOfChannels,
            bool? includeWordTimestamps,
            global::Inworld.VoiceProfileConfig? voiceProfileConfig)
        {
            this.ModelId = modelId;
            this.AudioEncoding = audioEncoding;
            this.Language = language;
            this.SampleRateHertz = sampleRateHertz;
            this.NumberOfChannels = numberOfChannels;
            this.IncludeWordTimestamps = includeWordTimestamps;
            this.VoiceProfileConfig = voiceProfileConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeConfig" /> class.
        /// </summary>
        public TranscribeConfig()
        {
        }

    }
}