
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttInworldSttV1Config
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minEndOfTurnSilenceWhenConfident")]
        public int? MinEndOfTurnSilenceWhenConfident { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vadThreshold")]
        public float? VadThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttInworldSttV1Config" /> class.
        /// </summary>
        /// <param name="minEndOfTurnSilenceWhenConfident"></param>
        /// <param name="vadThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttInworldSttV1Config(
            int? minEndOfTurnSilenceWhenConfident,
            float? vadThreshold)
        {
            this.MinEndOfTurnSilenceWhenConfident = minEndOfTurnSilenceWhenConfident;
            this.VadThreshold = vadThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttInworldSttV1Config" /> class.
        /// </summary>
        public SttInworldSttV1Config()
        {
        }

    }
}