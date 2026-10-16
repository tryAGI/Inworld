
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedConversationItemTruncatedType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemTruncated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedConversationItemTruncatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedConversationItemTruncatedType value)
        {
            return value switch
            {
                UnifiedConversationItemTruncatedType.ConversationItemTruncated => "conversation.item.truncated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedConversationItemTruncatedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.truncated" => UnifiedConversationItemTruncatedType.ConversationItemTruncated,
                _ => null,
            };
        }
    }
}