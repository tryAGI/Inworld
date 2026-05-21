
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttUsageData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribedAudioMs")]
        public int? TranscribedAudioMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttUsageData" /> class.
        /// </summary>
        /// <param name="transcribedAudioMs"></param>
        /// <param name="modelId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttUsageData(
            int? transcribedAudioMs,
            string? modelId)
        {
            this.TranscribedAudioMs = transcribedAudioMs;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttUsageData" /> class.
        /// </summary>
        public SttUsageData()
        {
        }

    }
}