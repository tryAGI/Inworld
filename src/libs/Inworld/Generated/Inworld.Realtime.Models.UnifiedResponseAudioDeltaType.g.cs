
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseAudioDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseAudioDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseAudioDeltaType value)
        {
            return value switch
            {
                UnifiedResponseAudioDeltaType.ResponseAudioDelta => "response.audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseAudioDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.delta" => UnifiedResponseAudioDeltaType.ResponseAudioDelta,
                _ => null,
            };
        }
    }
}