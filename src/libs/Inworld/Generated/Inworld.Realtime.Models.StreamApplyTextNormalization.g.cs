
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamApplyTextNormalization
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyTextNormalizationUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamApplyTextNormalization value)
        {
            return value switch
            {
                StreamApplyTextNormalization.ApplyTextNormalizationUnspecified => "APPLY_TEXT_NORMALIZATION_UNSPECIFIED",
                StreamApplyTextNormalization.Off => "OFF",
                StreamApplyTextNormalization.On => "ON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "APPLY_TEXT_NORMALIZATION_UNSPECIFIED" => StreamApplyTextNormalization.ApplyTextNormalizationUnspecified,
                "OFF" => StreamApplyTextNormalization.Off,
                "ON" => StreamApplyTextNormalization.On,
                _ => null,
            };
        }
    }
}