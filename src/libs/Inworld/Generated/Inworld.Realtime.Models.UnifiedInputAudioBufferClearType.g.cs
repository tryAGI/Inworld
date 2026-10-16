
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedInputAudioBufferClearType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferClear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedInputAudioBufferClearTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedInputAudioBufferClearType value)
        {
            return value switch
            {
                UnifiedInputAudioBufferClearType.InputAudioBufferClear => "input_audio_buffer.clear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedInputAudioBufferClearType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.clear" => UnifiedInputAudioBufferClearType.InputAudioBufferClear,
                _ => null,
            };
        }
    }
}