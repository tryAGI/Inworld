
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedInputAudioBufferSpeechStartedType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferSpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedInputAudioBufferSpeechStartedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedInputAudioBufferSpeechStartedType value)
        {
            return value switch
            {
                UnifiedInputAudioBufferSpeechStartedType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedInputAudioBufferSpeechStartedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_started" => UnifiedInputAudioBufferSpeechStartedType.InputAudioBufferSpeechStarted,
                _ => null,
            };
        }
    }
}