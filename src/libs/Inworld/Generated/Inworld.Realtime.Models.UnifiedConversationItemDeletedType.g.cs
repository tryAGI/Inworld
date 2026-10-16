
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedConversationItemDeletedType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedConversationItemDeletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedConversationItemDeletedType value)
        {
            return value switch
            {
                UnifiedConversationItemDeletedType.ConversationItemDeleted => "conversation.item.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedConversationItemDeletedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.deleted" => UnifiedConversationItemDeletedType.ConversationItemDeleted,
                _ => null,
            };
        }
    }
}