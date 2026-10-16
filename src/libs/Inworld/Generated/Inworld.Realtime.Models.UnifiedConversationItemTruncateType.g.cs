
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedConversationItemTruncateType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemTruncate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedConversationItemTruncateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedConversationItemTruncateType value)
        {
            return value switch
            {
                UnifiedConversationItemTruncateType.ConversationItemTruncate => "conversation.item.truncate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedConversationItemTruncateType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.truncate" => UnifiedConversationItemTruncateType.ConversationItemTruncate,
                _ => null,
            };
        }
    }
}