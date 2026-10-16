
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseCreateType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseCreateType value)
        {
            return value switch
            {
                UnifiedResponseCreateType.ResponseCreate => "response.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseCreateType? ToEnum(string value)
        {
            return value switch
            {
                "response.create" => UnifiedResponseCreateType.ResponseCreate,
                _ => null,
            };
        }
    }
}