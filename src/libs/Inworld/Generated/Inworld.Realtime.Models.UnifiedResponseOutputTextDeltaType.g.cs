
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseOutputTextDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseOutputTextDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseOutputTextDeltaType value)
        {
            return value switch
            {
                UnifiedResponseOutputTextDeltaType.ResponseOutputTextDelta => "response.output_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseOutputTextDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.delta" => UnifiedResponseOutputTextDeltaType.ResponseOutputTextDelta,
                _ => null,
            };
        }
    }
}