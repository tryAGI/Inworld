
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedInputAudioBufferTimeoutTriggeredType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferTimeoutTriggered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedInputAudioBufferTimeoutTriggeredTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedInputAudioBufferTimeoutTriggeredType value)
        {
            return value switch
            {
                UnifiedInputAudioBufferTimeoutTriggeredType.InputAudioBufferTimeoutTriggered => "input_audio_buffer.timeout_triggered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedInputAudioBufferTimeoutTriggeredType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.timeout_triggered" => UnifiedInputAudioBufferTimeoutTriggeredType.InputAudioBufferTimeoutTriggered,
                _ => null,
            };
        }
    }
}