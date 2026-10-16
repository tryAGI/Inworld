
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseFunctionCallArgumentsDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseFunctionCallArgumentsDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseFunctionCallArgumentsDeltaType value)
        {
            return value switch
            {
                UnifiedResponseFunctionCallArgumentsDeltaType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseFunctionCallArgumentsDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.delta" => UnifiedResponseFunctionCallArgumentsDeltaType.ResponseFunctionCallArgumentsDelta,
                _ => null,
            };
        }
    }
}