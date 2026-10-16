
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseCancelType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCancel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseCancelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseCancelType value)
        {
            return value switch
            {
                UnifiedResponseCancelType.ResponseCancel => "response.cancel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseCancelType? ToEnum(string value)
        {
            return value switch
            {
                "response.cancel" => UnifiedResponseCancelType.ResponseCancel,
                _ => null,
            };
        }
    }
}