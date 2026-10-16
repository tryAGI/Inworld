
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseCreatedType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseCreatedType value)
        {
            return value switch
            {
                UnifiedResponseCreatedType.ResponseCreated => "response.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "response.created" => UnifiedResponseCreatedType.ResponseCreated,
                _ => null,
            };
        }
    }
}