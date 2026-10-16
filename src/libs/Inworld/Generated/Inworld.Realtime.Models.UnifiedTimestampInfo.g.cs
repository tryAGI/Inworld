
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedTimestampInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_alignment")]
        public global::Inworld.Realtime.UnifiedTimestampInfoWordAlignment? WordAlignment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_alignment")]
        public global::Inworld.Realtime.UnifiedTimestampInfoCharacterAlignment? CharacterAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTimestampInfo" /> class.
        /// </summary>
        /// <param name="wordAlignment"></param>
        /// <param name="characterAlignment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedTimestampInfo(
            global::Inworld.Realtime.UnifiedTimestampInfoWordAlignment? wordAlignment,
            global::Inworld.Realtime.UnifiedTimestampInfoCharacterAlignment? characterAlignment)
        {
            this.WordAlignment = wordAlignment;
            this.CharacterAlignment = characterAlignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTimestampInfo" /> class.
        /// </summary>
        public UnifiedTimestampInfo()
        {
        }

    }
}