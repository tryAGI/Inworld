
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Tuning parameters for voice design.
    /// </summary>
    public sealed partial class VoiceDesignConfig
    {
        /// <summary>
        /// Number of preview voices to generate. Range [1, 3]. Defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfSamples")]
        public int? NumberOfSamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignConfig" /> class.
        /// </summary>
        /// <param name="numberOfSamples">
        /// Number of preview voices to generate. Range [1, 3]. Defaults to 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceDesignConfig(
            int? numberOfSamples)
        {
            this.NumberOfSamples = numberOfSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignConfig" /> class.
        /// </summary>
        public VoiceDesignConfig()
        {
        }

    }
}