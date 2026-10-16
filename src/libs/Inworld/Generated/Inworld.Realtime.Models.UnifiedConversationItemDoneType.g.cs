
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedConversationItemDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedConversationItemDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedConversationItemDoneType value)
        {
            return value switch
            {
                UnifiedConversationItemDoneType.ConversationItemDone => "conversation.item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedConversationItemDoneType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.done" => UnifiedConversationItemDoneType.ConversationItemDone,
                _ => null,
            };
        }
    }
}