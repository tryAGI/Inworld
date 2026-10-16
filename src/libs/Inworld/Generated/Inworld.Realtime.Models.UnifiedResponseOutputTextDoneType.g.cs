
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseOutputTextDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseOutputTextDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseOutputTextDoneType value)
        {
            return value switch
            {
                UnifiedResponseOutputTextDoneType.ResponseOutputTextDone => "response.output_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseOutputTextDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.done" => UnifiedResponseOutputTextDoneType.ResponseOutputTextDone,
                _ => null,
            };
        }
    }
}