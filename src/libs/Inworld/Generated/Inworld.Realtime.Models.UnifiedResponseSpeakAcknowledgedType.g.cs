
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseSpeakAcknowledgedType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseSpeakAcknowledged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseSpeakAcknowledgedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseSpeakAcknowledgedType value)
        {
            return value switch
            {
                UnifiedResponseSpeakAcknowledgedType.ResponseSpeakAcknowledged => "response.speak.acknowledged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseSpeakAcknowledgedType? ToEnum(string value)
        {
            return value switch
            {
                "response.speak.acknowledged" => UnifiedResponseSpeakAcknowledgedType.ResponseSpeakAcknowledged,
                _ => null,
            };
        }
    }
}