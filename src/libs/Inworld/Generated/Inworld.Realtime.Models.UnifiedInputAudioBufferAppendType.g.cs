
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedInputAudioBufferAppendType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedInputAudioBufferAppendTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedInputAudioBufferAppendType value)
        {
            return value switch
            {
                UnifiedInputAudioBufferAppendType.InputAudioBufferAppend => "input_audio_buffer.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedInputAudioBufferAppendType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.append" => UnifiedInputAudioBufferAppendType.InputAudioBufferAppend,
                _ => null,
            };
        }
    }
}