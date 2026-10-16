
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedConversationItemCreateType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedConversationItemCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedConversationItemCreateType value)
        {
            return value switch
            {
                UnifiedConversationItemCreateType.ConversationItemCreate => "conversation.item.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedConversationItemCreateType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.create" => UnifiedConversationItemCreateType.ConversationItemCreate,
                _ => null,
            };
        }
    }
}