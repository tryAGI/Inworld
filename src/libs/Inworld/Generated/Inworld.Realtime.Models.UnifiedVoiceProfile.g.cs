
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedVoiceProfile
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? Age { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? Emotion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? Pitch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vocal_style")]
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? VocalStyle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? Accent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedVoiceProfile" /> class.
        /// </summary>
        /// <param name="age"></param>
        /// <param name="emotion"></param>
        /// <param name="pitch"></param>
        /// <param name="vocalStyle"></param>
        /// <param name="accent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedVoiceProfile(
            global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? age,
            global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? emotion,
            global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? pitch,
            global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? vocalStyle,
            global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? accent)
        {
            this.Age = age;
            this.Emotion = emotion;
            this.Pitch = pitch;
            this.VocalStyle = vocalStyle;
            this.Accent = accent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedVoiceProfile" /> class.
        /// </summary>
        public UnifiedVoiceProfile()
        {
        }

    }
}