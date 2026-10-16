
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedRateLimitsUpdatedType
    {
        /// <summary>
        ///
        /// </summary>
        RateLimitsUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedRateLimitsUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedRateLimitsUpdatedType value)
        {
            return value switch
            {
                UnifiedRateLimitsUpdatedType.RateLimitsUpdated => "rate_limits.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedRateLimitsUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "rate_limits.updated" => UnifiedRateLimitsUpdatedType.RateLimitsUpdated,
                _ => null,
            };
        }
    }
}