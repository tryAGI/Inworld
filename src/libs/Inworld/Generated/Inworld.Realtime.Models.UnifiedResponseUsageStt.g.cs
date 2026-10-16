
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseUsageStt
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_seconds")]
        public double? AudioSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseUsageStt" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="audioSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseUsageStt(
            string? model,
            double? audioSeconds)
        {
            this.Model = model;
            this.AudioSeconds = audioSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseUsageStt" /> class.
        /// </summary>
        public UnifiedResponseUsageStt()
        {
        }

    }
}