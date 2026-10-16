
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseOutputAudioDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseOutputAudioDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseOutputAudioDeltaType value)
        {
            return value switch
            {
                UnifiedResponseOutputAudioDeltaType.ResponseOutputAudioDelta => "response.output_audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseOutputAudioDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio.delta" => UnifiedResponseOutputAudioDeltaType.ResponseOutputAudioDelta,
                _ => null,
            };
        }
    }
}