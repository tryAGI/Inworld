
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedConversationItemDeleteType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemDelete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedConversationItemDeleteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedConversationItemDeleteType value)
        {
            return value switch
            {
                UnifiedConversationItemDeleteType.ConversationItemDelete => "conversation.item.delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedConversationItemDeleteType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.delete" => UnifiedConversationItemDeleteType.ConversationItemDelete,
                _ => null,
            };
        }
    }
}