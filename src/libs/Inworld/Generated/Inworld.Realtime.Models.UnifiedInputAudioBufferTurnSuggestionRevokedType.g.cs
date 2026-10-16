
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedInputAudioBufferTurnSuggestionRevokedType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferTurnSuggestionRevoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedInputAudioBufferTurnSuggestionRevokedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedInputAudioBufferTurnSuggestionRevokedType value)
        {
            return value switch
            {
                UnifiedInputAudioBufferTurnSuggestionRevokedType.InputAudioBufferTurnSuggestionRevoked => "input_audio_buffer.turn_suggestion_revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedInputAudioBufferTurnSuggestionRevokedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.turn_suggestion_revoked" => UnifiedInputAudioBufferTurnSuggestionRevokedType.InputAudioBufferTurnSuggestionRevoked,
                _ => null,
            };
        }
    }
}