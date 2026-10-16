
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseBackchannelAudioDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseBackchannelAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseBackchannelAudioDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseBackchannelAudioDeltaType value)
        {
            return value switch
            {
                UnifiedResponseBackchannelAudioDeltaType.ResponseBackchannelAudioDelta => "response.backchannel.audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseBackchannelAudioDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.backchannel.audio.delta" => UnifiedResponseBackchannelAudioDeltaType.ResponseBackchannelAudioDelta,
                _ => null,
            };
        }
    }
}