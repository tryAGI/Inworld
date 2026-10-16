
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedInputAudioBufferTurnSuggestionType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferTurnSuggestion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedInputAudioBufferTurnSuggestionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedInputAudioBufferTurnSuggestionType value)
        {
            return value switch
            {
                UnifiedInputAudioBufferTurnSuggestionType.InputAudioBufferTurnSuggestion => "input_audio_buffer.turn_suggestion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedInputAudioBufferTurnSuggestionType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.turn_suggestion" => UnifiedInputAudioBufferTurnSuggestionType.InputAudioBufferTurnSuggestion,
                _ => null,
            };
        }
    }
}