
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedConversationItemRetrieveType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemRetrieve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedConversationItemRetrieveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedConversationItemRetrieveType value)
        {
            return value switch
            {
                UnifiedConversationItemRetrieveType.ConversationItemRetrieve => "conversation.item.retrieve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedConversationItemRetrieveType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.retrieve" => UnifiedConversationItemRetrieveType.ConversationItemRetrieve,
                _ => null,
            };
        }
    }
}