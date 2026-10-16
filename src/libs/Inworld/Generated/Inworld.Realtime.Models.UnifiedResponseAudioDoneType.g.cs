
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseAudioDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseAudioDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseAudioDoneType value)
        {
            return value switch
            {
                UnifiedResponseAudioDoneType.ResponseAudioDone => "response.audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseAudioDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.done" => UnifiedResponseAudioDoneType.ResponseAudioDone,
                _ => null,
            };
        }
    }
}