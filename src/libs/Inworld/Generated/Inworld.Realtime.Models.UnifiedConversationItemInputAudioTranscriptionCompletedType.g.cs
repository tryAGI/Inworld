
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedConversationItemInputAudioTranscriptionCompletedType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemInputAudioTranscriptionCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedConversationItemInputAudioTranscriptionCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedConversationItemInputAudioTranscriptionCompletedType value)
        {
            return value switch
            {
                UnifiedConversationItemInputAudioTranscriptionCompletedType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedConversationItemInputAudioTranscriptionCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.completed" => UnifiedConversationItemInputAudioTranscriptionCompletedType.ConversationItemInputAudioTranscriptionCompleted,
                _ => null,
            };
        }
    }
}