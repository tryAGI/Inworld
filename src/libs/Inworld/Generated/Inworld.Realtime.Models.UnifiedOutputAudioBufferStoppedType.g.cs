
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedOutputAudioBufferStoppedType
    {
        /// <summary>
        ///
        /// </summary>
        OutputAudioBufferStopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedOutputAudioBufferStoppedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedOutputAudioBufferStoppedType value)
        {
            return value switch
            {
                UnifiedOutputAudioBufferStoppedType.OutputAudioBufferStopped => "output_audio_buffer.stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedOutputAudioBufferStoppedType? ToEnum(string value)
        {
            return value switch
            {
                "output_audio_buffer.stopped" => UnifiedOutputAudioBufferStoppedType.OutputAudioBufferStopped,
                _ => null,
            };
        }
    }
}