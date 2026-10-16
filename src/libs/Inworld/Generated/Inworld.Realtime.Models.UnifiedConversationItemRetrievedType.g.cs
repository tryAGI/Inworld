
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedConversationItemRetrievedType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemRetrieved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedConversationItemRetrievedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedConversationItemRetrievedType value)
        {
            return value switch
            {
                UnifiedConversationItemRetrievedType.ConversationItemRetrieved => "conversation.item.retrieved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedConversationItemRetrievedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.retrieved" => UnifiedConversationItemRetrievedType.ConversationItemRetrieved,
                _ => null,
            };
        }
    }
}