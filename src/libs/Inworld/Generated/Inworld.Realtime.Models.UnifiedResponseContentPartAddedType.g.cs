
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseContentPartAddedType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseContentPartAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseContentPartAddedType value)
        {
            return value switch
            {
                UnifiedResponseContentPartAddedType.ResponseContentPartAdded => "response.content_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseContentPartAddedType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.added" => UnifiedResponseContentPartAddedType.ResponseContentPartAdded,
                _ => null,
            };
        }
    }
}