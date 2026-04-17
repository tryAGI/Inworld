
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Optional voice profiling (speaker characteristics detection).
    /// </summary>
    public sealed partial class VoiceProfileConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableVoiceProfile")]
        public bool? EnableVoiceProfile { get; set; }

        /// <summary>
        /// Number of top candidate labels to return per attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topN")]
        public int? TopN { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceProfileConfig" /> class.
        /// </summary>
        /// <param name="enableVoiceProfile"></param>
        /// <param name="topN">
        /// Number of top candidate labels to return per attribute.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceProfileConfig(
            bool? enableVoiceProfile,
            int? topN)
        {
            this.EnableVoiceProfile = enableVoiceProfile;
            this.TopN = topN;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceProfileConfig" /> class.
        /// </summary>
        public VoiceProfileConfig()
        {
        }
    }
}