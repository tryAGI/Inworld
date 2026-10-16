
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedOutputAudioBufferClearedType
    {
        /// <summary>
        ///
        /// </summary>
        OutputAudioBufferCleared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedOutputAudioBufferClearedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedOutputAudioBufferClearedType value)
        {
            return value switch
            {
                UnifiedOutputAudioBufferClearedType.OutputAudioBufferCleared => "output_audio_buffer.cleared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedOutputAudioBufferClearedType? ToEnum(string value)
        {
            return value switch
            {
                "output_audio_buffer.cleared" => UnifiedOutputAudioBufferClearedType.OutputAudioBufferCleared,
                _ => null,
            };
        }
    }
}