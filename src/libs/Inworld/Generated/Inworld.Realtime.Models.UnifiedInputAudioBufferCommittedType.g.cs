
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedInputAudioBufferCommittedType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferCommitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedInputAudioBufferCommittedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedInputAudioBufferCommittedType value)
        {
            return value switch
            {
                UnifiedInputAudioBufferCommittedType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedInputAudioBufferCommittedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.committed" => UnifiedInputAudioBufferCommittedType.InputAudioBufferCommitted,
                _ => null,
            };
        }
    }
}