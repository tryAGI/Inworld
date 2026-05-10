
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsTimestampInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordAlignment")]
        public global::Inworld.Realtime.TtsWordAlignment? WordAlignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characterAlignment")]
        public global::Inworld.Realtime.TtsCharacterAlignment? CharacterAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTimestampInfo" /> class.
        /// </summary>
        /// <param name="wordAlignment"></param>
        /// <param name="characterAlignment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTimestampInfo(
            global::Inworld.Realtime.TtsWordAlignment? wordAlignment,
            global::Inworld.Realtime.TtsCharacterAlignment? characterAlignment)
        {
            this.WordAlignment = wordAlignment;
            this.CharacterAlignment = characterAlignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTimestampInfo" /> class.
        /// </summary>
        public TtsTimestampInfo()
        {
        }

    }
}