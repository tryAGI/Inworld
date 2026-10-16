
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseBackchannelAudioDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseBackchannelAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseBackchannelAudioDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseBackchannelAudioDoneType value)
        {
            return value switch
            {
                UnifiedResponseBackchannelAudioDoneType.ResponseBackchannelAudioDone => "response.backchannel.audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseBackchannelAudioDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.backchannel.audio.done" => UnifiedResponseBackchannelAudioDoneType.ResponseBackchannelAudioDone,
                _ => null,
            };
        }
    }
}