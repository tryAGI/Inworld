
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedProviderData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_tool_response")]
        public bool? AutoToolResponse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceProfile")]
        public global::Inworld.Realtime.UnifiedVoiceProfile? VoiceProfile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        public global::Inworld.Realtime.UnifiedSttProviderData? Stt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::Inworld.Realtime.UnifiedTtsProviderData? Tts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public global::Inworld.Realtime.UnifiedMemoryProviderData? Memory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backchannel")]
        public global::Inworld.Realtime.UnifiedBackchannelProviderData? Backchannel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responsiveness")]
        public global::Inworld.Realtime.UnifiedResponsivenessProviderData? Responsiveness { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_generation_config")]
        public global::Inworld.Realtime.UnifiedTextGenerationConfig? TextGenerationConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedProviderData" /> class.
        /// </summary>
        /// <param name="autoToolResponse"></param>
        /// <param name="voiceProfile"></param>
        /// <param name="stt"></param>
        /// <param name="tts"></param>
        /// <param name="memory"></param>
        /// <param name="backchannel"></param>
        /// <param name="responsiveness"></param>
        /// <param name="textGenerationConfig"></param>
        /// <param name="userId"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedProviderData(
            bool? autoToolResponse,
            global::Inworld.Realtime.UnifiedVoiceProfile? voiceProfile,
            global::Inworld.Realtime.UnifiedSttProviderData? stt,
            global::Inworld.Realtime.UnifiedTtsProviderData? tts,
            global::Inworld.Realtime.UnifiedMemoryProviderData? memory,
            global::Inworld.Realtime.UnifiedBackchannelProviderData? backchannel,
            global::Inworld.Realtime.UnifiedResponsivenessProviderData? responsiveness,
            global::Inworld.Realtime.UnifiedTextGenerationConfig? textGenerationConfig,
            string? userId,
            object? metadata)
        {
            this.AutoToolResponse = autoToolResponse;
            this.VoiceProfile = voiceProfile;
            this.Stt = stt;
            this.Tts = tts;
            this.Memory = memory;
            this.Backchannel = backchannel;
            this.Responsiveness = responsiveness;
            this.TextGenerationConfig = textGenerationConfig;
            this.UserId = userId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedProviderData" /> class.
        /// </summary>
        public UnifiedProviderData()
        {
        }

    }
}