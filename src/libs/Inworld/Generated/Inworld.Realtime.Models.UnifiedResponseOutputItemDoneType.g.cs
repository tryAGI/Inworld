
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseOutputItemDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseOutputItemDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseOutputItemDoneType value)
        {
            return value switch
            {
                UnifiedResponseOutputItemDoneType.ResponseOutputItemDone => "response.output_item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseOutputItemDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.done" => UnifiedResponseOutputItemDoneType.ResponseOutputItemDone,
                _ => null,
            };
        }
    }
}