
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Timestamp information for synthesized audio.
    /// </summary>
    public sealed partial class TimestampInfo
    {
        /// <summary>
        /// Word-level timestamp alignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordAlignment")]
        public global::Inworld.WordAlignment? WordAlignment { get; set; }

        /// <summary>
        /// Character-level timestamp alignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characterAlignment")]
        public global::Inworld.CharacterAlignment? CharacterAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampInfo" /> class.
        /// </summary>
        /// <param name="wordAlignment">
        /// Word-level timestamp alignment.
        /// </param>
        /// <param name="characterAlignment">
        /// Character-level timestamp alignment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimestampInfo(
            global::Inworld.WordAlignment? wordAlignment,
            global::Inworld.CharacterAlignment? characterAlignment)
        {
            this.WordAlignment = wordAlignment;
            this.CharacterAlignment = characterAlignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampInfo" /> class.
        /// </summary>
        public TimestampInfo()
        {
        }
    }
}