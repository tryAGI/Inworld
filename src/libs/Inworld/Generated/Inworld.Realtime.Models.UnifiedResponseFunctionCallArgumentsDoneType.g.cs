
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseFunctionCallArgumentsDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseFunctionCallArgumentsDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseFunctionCallArgumentsDoneType value)
        {
            return value switch
            {
                UnifiedResponseFunctionCallArgumentsDoneType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseFunctionCallArgumentsDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.done" => UnifiedResponseFunctionCallArgumentsDoneType.ResponseFunctionCallArgumentsDone,
                _ => null,
            };
        }
    }
}