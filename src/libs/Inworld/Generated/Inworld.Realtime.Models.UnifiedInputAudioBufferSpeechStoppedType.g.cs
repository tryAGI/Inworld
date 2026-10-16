
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedInputAudioBufferSpeechStoppedType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferSpeechStopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedInputAudioBufferSpeechStoppedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedInputAudioBufferSpeechStoppedType value)
        {
            return value switch
            {
                UnifiedInputAudioBufferSpeechStoppedType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedInputAudioBufferSpeechStoppedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_stopped" => UnifiedInputAudioBufferSpeechStoppedType.InputAudioBufferSpeechStopped,
                _ => null,
            };
        }
    }
}