
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseOutputAudioDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseOutputAudioDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseOutputAudioDoneType value)
        {
            return value switch
            {
                UnifiedResponseOutputAudioDoneType.ResponseOutputAudioDone => "response.output_audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseOutputAudioDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio.done" => UnifiedResponseOutputAudioDoneType.ResponseOutputAudioDone,
                _ => null,
            };
        }
    }
}