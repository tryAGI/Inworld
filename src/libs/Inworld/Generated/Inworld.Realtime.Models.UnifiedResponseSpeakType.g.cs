
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseSpeakType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseSpeak,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseSpeakTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseSpeakType value)
        {
            return value switch
            {
                UnifiedResponseSpeakType.ResponseSpeak => "response.speak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseSpeakType? ToEnum(string value)
        {
            return value switch
            {
                "response.speak" => UnifiedResponseSpeakType.ResponseSpeak,
                _ => null,
            };
        }
    }
}