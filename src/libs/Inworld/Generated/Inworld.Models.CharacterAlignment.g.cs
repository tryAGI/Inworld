
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Character-level timestamp alignment.
    /// </summary>
    public sealed partial class CharacterAlignment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public global::System.Collections.Generic.IList<string>? Characters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characterStartTimeSeconds")]
        public global::System.Collections.Generic.IList<double>? CharacterStartTimeSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characterEndTimeSeconds")]
        public global::System.Collections.Generic.IList<double>? CharacterEndTimeSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterAlignment" /> class.
        /// </summary>
        /// <param name="characters"></param>
        /// <param name="characterStartTimeSeconds"></param>
        /// <param name="characterEndTimeSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CharacterAlignment(
            global::System.Collections.Generic.IList<string>? characters,
            global::System.Collections.Generic.IList<double>? characterStartTimeSeconds,
            global::System.Collections.Generic.IList<double>? characterEndTimeSeconds)
        {
            this.Characters = characters;
            this.CharacterStartTimeSeconds = characterStartTimeSeconds;
            this.CharacterEndTimeSeconds = characterEndTimeSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterAlignment" /> class.
        /// </summary>
        public CharacterAlignment()
        {
        }

    }
}