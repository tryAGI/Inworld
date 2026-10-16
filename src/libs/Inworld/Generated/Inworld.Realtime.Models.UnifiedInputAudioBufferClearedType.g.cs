
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedInputAudioBufferClearedType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferCleared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedInputAudioBufferClearedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedInputAudioBufferClearedType value)
        {
            return value switch
            {
                UnifiedInputAudioBufferClearedType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedInputAudioBufferClearedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.cleared" => UnifiedInputAudioBufferClearedType.InputAudioBufferCleared,
                _ => null,
            };
        }
    }
}