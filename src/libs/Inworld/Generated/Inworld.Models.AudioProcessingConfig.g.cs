
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Preprocessing applied to clone-voice samples.
    /// </summary>
    public sealed partial class AudioProcessingConfig
    {
        /// <summary>
        /// Whether to strip background noise from the samples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeBackgroundNoise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioProcessingConfig" /> class.
        /// </summary>
        /// <param name="removeBackgroundNoise">
        /// Whether to strip background noise from the samples.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioProcessingConfig(
            bool? removeBackgroundNoise)
        {
            this.RemoveBackgroundNoise = removeBackgroundNoise;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioProcessingConfig" /> class.
        /// </summary>
        public AudioProcessingConfig()
        {
        }
    }
}