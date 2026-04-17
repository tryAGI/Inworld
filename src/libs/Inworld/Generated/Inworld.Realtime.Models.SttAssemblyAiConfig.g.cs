
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttAssemblyAiConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minEndOfTurnSilenceWhenConfident")]
        public int? MinEndOfTurnSilenceWhenConfident { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTurnSilence")]
        public int? MaxTurnSilence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vadThreshold")]
        public float? VadThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttAssemblyAiConfig" /> class.
        /// </summary>
        /// <param name="minEndOfTurnSilenceWhenConfident"></param>
        /// <param name="maxTurnSilence"></param>
        /// <param name="vadThreshold"></param>
        /// <param name="prompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttAssemblyAiConfig(
            int? minEndOfTurnSilenceWhenConfident,
            int? maxTurnSilence,
            float? vadThreshold,
            string? prompt)
        {
            this.MinEndOfTurnSilenceWhenConfident = minEndOfTurnSilenceWhenConfident;
            this.MaxTurnSilence = maxTurnSilence;
            this.VadThreshold = vadThreshold;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttAssemblyAiConfig" /> class.
        /// </summary>
        public SttAssemblyAiConfig()
        {
        }
    }
}