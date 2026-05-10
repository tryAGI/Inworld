
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttTranscribeConfigParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioEncoding")]
        public string? AudioEncoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRateHertz")]
        public int? SampleRateHertz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfChannels")]
        public int? NumberOfChannels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivityTimeoutSeconds")]
        public int? InactivityTimeoutSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endOfTurnConfidenceThreshold")]
        public float? EndOfTurnConfidenceThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        public global::System.Collections.Generic.IList<string>? Prompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeWordTimestamps")]
        public bool? IncludeWordTimestamps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groqConfig")]
        public global::Inworld.Realtime.SttGroqConfig? GroqConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assemblyaiConfig")]
        public global::Inworld.Realtime.SttAssemblyAiConfig? AssemblyaiConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inworldSttV1Config")]
        public global::Inworld.Realtime.SttInworldSttV1Config? InworldSttV1Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceProfileConfig")]
        public global::Inworld.Realtime.SttVoiceProfileConfig? VoiceProfileConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttTranscribeConfigParams" /> class.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="audioEncoding"></param>
        /// <param name="language"></param>
        /// <param name="sampleRateHertz"></param>
        /// <param name="numberOfChannels"></param>
        /// <param name="inactivityTimeoutSeconds"></param>
        /// <param name="endOfTurnConfidenceThreshold"></param>
        /// <param name="prompts"></param>
        /// <param name="includeWordTimestamps"></param>
        /// <param name="groqConfig"></param>
        /// <param name="assemblyaiConfig"></param>
        /// <param name="inworldSttV1Config"></param>
        /// <param name="voiceProfileConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttTranscribeConfigParams(
            string? modelId,
            string? audioEncoding,
            string? language,
            int? sampleRateHertz,
            int? numberOfChannels,
            int? inactivityTimeoutSeconds,
            float? endOfTurnConfidenceThreshold,
            global::System.Collections.Generic.IList<string>? prompts,
            bool? includeWordTimestamps,
            global::Inworld.Realtime.SttGroqConfig? groqConfig,
            global::Inworld.Realtime.SttAssemblyAiConfig? assemblyaiConfig,
            global::Inworld.Realtime.SttInworldSttV1Config? inworldSttV1Config,
            global::Inworld.Realtime.SttVoiceProfileConfig? voiceProfileConfig)
        {
            this.ModelId = modelId;
            this.AudioEncoding = audioEncoding;
            this.Language = language;
            this.SampleRateHertz = sampleRateHertz;
            this.NumberOfChannels = numberOfChannels;
            this.InactivityTimeoutSeconds = inactivityTimeoutSeconds;
            this.EndOfTurnConfidenceThreshold = endOfTurnConfidenceThreshold;
            this.Prompts = prompts;
            this.IncludeWordTimestamps = includeWordTimestamps;
            this.GroqConfig = groqConfig;
            this.AssemblyaiConfig = assemblyaiConfig;
            this.InworldSttV1Config = inworldSttV1Config;
            this.VoiceProfileConfig = voiceProfileConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttTranscribeConfigParams" /> class.
        /// </summary>
        public SttTranscribeConfigParams()
        {
        }

    }
}