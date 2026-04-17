
#nullable enable

namespace Inworld
{
    /// <summary>
    /// A single phone within a word-level alignment.
    /// </summary>
    public sealed partial class Phone
    {
        /// <summary>
        /// IPA phone symbol.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneSymbol")]
        public string? PhoneSymbol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimeSeconds")]
        public double? StartTimeSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationSeconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Associated viseme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visemeSymbol")]
        public string? VisemeSymbol { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Phone" /> class.
        /// </summary>
        /// <param name="phoneSymbol">
        /// IPA phone symbol.
        /// </param>
        /// <param name="startTimeSeconds"></param>
        /// <param name="durationSeconds"></param>
        /// <param name="visemeSymbol">
        /// Associated viseme.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Phone(
            string? phoneSymbol,
            double? startTimeSeconds,
            double? durationSeconds,
            string? visemeSymbol)
        {
            this.PhoneSymbol = phoneSymbol;
            this.StartTimeSeconds = startTimeSeconds;
            this.DurationSeconds = durationSeconds;
            this.VisemeSymbol = visemeSymbol;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Phone" /> class.
        /// </summary>
        public Phone()
        {
        }
    }
}