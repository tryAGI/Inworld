
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedVoiceProfileLabel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedVoiceProfileLabel" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="confidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedVoiceProfileLabel(
            string? label,
            double? confidence)
        {
            this.Label = label;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedVoiceProfileLabel" /> class.
        /// </summary>
        public UnifiedVoiceProfileLabel()
        {
        }

    }
}