
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseBackchannelSkippedType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseBackchannelSkipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseBackchannelSkippedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseBackchannelSkippedType value)
        {
            return value switch
            {
                UnifiedResponseBackchannelSkippedType.ResponseBackchannelSkipped => "response.backchannel.skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseBackchannelSkippedType? ToEnum(string value)
        {
            return value switch
            {
                "response.backchannel.skipped" => UnifiedResponseBackchannelSkippedType.ResponseBackchannelSkipped,
                _ => null,
            };
        }
    }
}