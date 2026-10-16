
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedSessionCreatedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedSessionCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedSessionCreatedType value)
        {
            return value switch
            {
                UnifiedSessionCreatedType.SessionCreated => "session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedSessionCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.created" => UnifiedSessionCreatedType.SessionCreated,
                _ => null,
            };
        }
    }
}