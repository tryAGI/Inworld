
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedConversationItemInputAudioTranscriptionDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemInputAudioTranscriptionDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedConversationItemInputAudioTranscriptionDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedConversationItemInputAudioTranscriptionDeltaType value)
        {
            return value switch
            {
                UnifiedConversationItemInputAudioTranscriptionDeltaType.ConversationItemInputAudioTranscriptionDelta => "conversation.item.input_audio_transcription.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedConversationItemInputAudioTranscriptionDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.delta" => UnifiedConversationItemInputAudioTranscriptionDeltaType.ConversationItemInputAudioTranscriptionDelta,
                _ => null,
            };
        }
    }
}