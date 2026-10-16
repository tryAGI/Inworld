
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedOutputAudioBufferClearType
    {
        /// <summary>
        ///
        /// </summary>
        OutputAudioBufferClear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedOutputAudioBufferClearTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedOutputAudioBufferClearType value)
        {
            return value switch
            {
                UnifiedOutputAudioBufferClearType.OutputAudioBufferClear => "output_audio_buffer.clear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedOutputAudioBufferClearType? ToEnum(string value)
        {
            return value switch
            {
                "output_audio_buffer.clear" => UnifiedOutputAudioBufferClearType.OutputAudioBufferClear,
                _ => null,
            };
        }
    }
}