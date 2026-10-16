
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedSessionUpdateType
    {
        /// <summary>
        ///
        /// </summary>
        SessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedSessionUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedSessionUpdateType value)
        {
            return value switch
            {
                UnifiedSessionUpdateType.SessionUpdate => "session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedSessionUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "session.update" => UnifiedSessionUpdateType.SessionUpdate,
                _ => null,
            };
        }
    }
}