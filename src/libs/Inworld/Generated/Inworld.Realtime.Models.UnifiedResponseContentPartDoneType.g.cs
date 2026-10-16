
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseContentPartDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseContentPartDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseContentPartDoneType value)
        {
            return value switch
            {
                UnifiedResponseContentPartDoneType.ResponseContentPartDone => "response.content_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseContentPartDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.done" => UnifiedResponseContentPartDoneType.ResponseContentPartDone,
                _ => null,
            };
        }
    }
}