
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseTextDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseTextDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseTextDeltaType value)
        {
            return value switch
            {
                UnifiedResponseTextDeltaType.ResponseTextDelta => "response.text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseTextDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.text.delta" => UnifiedResponseTextDeltaType.ResponseTextDelta,
                _ => null,
            };
        }
    }
}