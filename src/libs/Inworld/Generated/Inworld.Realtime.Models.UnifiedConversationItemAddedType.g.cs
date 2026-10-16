
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedConversationItemAddedType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedConversationItemAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedConversationItemAddedType value)
        {
            return value switch
            {
                UnifiedConversationItemAddedType.ConversationItemAdded => "conversation.item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedConversationItemAddedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.added" => UnifiedConversationItemAddedType.ConversationItemAdded,
                _ => null,
            };
        }
    }
}