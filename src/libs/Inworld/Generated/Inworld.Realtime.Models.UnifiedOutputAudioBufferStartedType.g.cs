
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedOutputAudioBufferStartedType
    {
        /// <summary>
        ///
        /// </summary>
        OutputAudioBufferStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedOutputAudioBufferStartedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedOutputAudioBufferStartedType value)
        {
            return value switch
            {
                UnifiedOutputAudioBufferStartedType.OutputAudioBufferStarted => "output_audio_buffer.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedOutputAudioBufferStartedType? ToEnum(string value)
        {
            return value switch
            {
                "output_audio_buffer.started" => UnifiedOutputAudioBufferStartedType.OutputAudioBufferStarted,
                _ => null,
            };
        }
    }
}