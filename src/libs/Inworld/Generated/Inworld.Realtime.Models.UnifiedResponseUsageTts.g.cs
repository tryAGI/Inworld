
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseUsageTts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public int? Characters { get; set; }

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
        /// Initializes a new instance of the <see cref="UnifiedResponseUsageTts" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="characters"></param>
        /// <param name="audioSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseUsageTts(
            string? model,
            int? characters,
            double? audioSeconds)
        {
            this.Model = model;
            this.Characters = characters;
            this.AudioSeconds = audioSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseUsageTts" /> class.
        /// </summary>
        public UnifiedResponseUsageTts()
        {
        }

    }
}