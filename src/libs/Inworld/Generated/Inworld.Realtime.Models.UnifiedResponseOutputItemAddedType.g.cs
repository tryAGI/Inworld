
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseOutputItemAddedType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseOutputItemAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseOutputItemAddedType value)
        {
            return value switch
            {
                UnifiedResponseOutputItemAddedType.ResponseOutputItemAdded => "response.output_item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseOutputItemAddedType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.added" => UnifiedResponseOutputItemAddedType.ResponseOutputItemAdded,
                _ => null,
            };
        }
    }
}