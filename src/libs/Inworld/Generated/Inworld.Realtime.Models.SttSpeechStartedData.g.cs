
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttSpeechStartedData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimeMs")]
        public int? StartTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public float? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttSpeechStartedData" /> class.
        /// </summary>
        /// <param name="startTimeMs"></param>
        /// <param name="confidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttSpeechStartedData(
            int? startTimeMs,
            float? confidence)
        {
            this.StartTimeMs = startTimeMs;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttSpeechStartedData" /> class.
        /// </summary>
        public SttSpeechStartedData()
        {
        }

    }
}