
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedTimestampInfoCharacterAlignment
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public global::System.Collections.Generic.IList<string>? Characters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_start_time_seconds")]
        public global::System.Collections.Generic.IList<double>? CharacterStartTimeSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_end_time_seconds")]
        public global::System.Collections.Generic.IList<double>? CharacterEndTimeSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTimestampInfoCharacterAlignment" /> class.
        /// </summary>
        /// <param name="characters"></param>
        /// <param name="characterStartTimeSeconds"></param>
        /// <param name="characterEndTimeSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedTimestampInfoCharacterAlignment(
            global::System.Collections.Generic.IList<string>? characters,
            global::System.Collections.Generic.IList<double>? characterStartTimeSeconds,
            global::System.Collections.Generic.IList<double>? characterEndTimeSeconds)
        {
            this.Characters = characters;
            this.CharacterStartTimeSeconds = characterStartTimeSeconds;
            this.CharacterEndTimeSeconds = characterEndTimeSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTimestampInfoCharacterAlignment" /> class.
        /// </summary>
        public UnifiedTimestampInfoCharacterAlignment()
        {
        }

    }
}