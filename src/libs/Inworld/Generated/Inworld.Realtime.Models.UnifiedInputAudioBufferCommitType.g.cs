
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedInputAudioBufferCommitType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferCommit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedInputAudioBufferCommitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedInputAudioBufferCommitType value)
        {
            return value switch
            {
                UnifiedInputAudioBufferCommitType.InputAudioBufferCommit => "input_audio_buffer.commit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedInputAudioBufferCommitType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.commit" => UnifiedInputAudioBufferCommitType.InputAudioBufferCommit,
                _ => null,
            };
        }
    }
}