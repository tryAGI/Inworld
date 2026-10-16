
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseDoneType value)
        {
            return value switch
            {
                UnifiedResponseDoneType.ResponseDone => "response.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.done" => UnifiedResponseDoneType.ResponseDone,
                _ => null,
            };
        }
    }
}