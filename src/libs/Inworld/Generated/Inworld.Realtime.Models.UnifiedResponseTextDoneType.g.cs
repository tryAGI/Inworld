
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseTextDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseTextDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseTextDoneType value)
        {
            return value switch
            {
                UnifiedResponseTextDoneType.ResponseTextDone => "response.text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseTextDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.text.done" => UnifiedResponseTextDoneType.ResponseTextDone,
                _ => null,
            };
        }
    }
}