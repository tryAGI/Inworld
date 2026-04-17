
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Whether text normalization is applied before synthesis.
    /// </summary>
    public enum ApplyTextNormalization
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
    public static class ApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyTextNormalization value)
        {
            return value switch
            {
                ApplyTextNormalization.ApplyTextNormalizationUnspecified => "APPLY_TEXT_NORMALIZATION_UNSPECIFIED",
                ApplyTextNormalization.Off => "OFF",
                ApplyTextNormalization.On => "ON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "APPLY_TEXT_NORMALIZATION_UNSPECIFIED" => ApplyTextNormalization.ApplyTextNormalizationUnspecified,
                "OFF" => ApplyTextNormalization.Off,
                "ON" => ApplyTextNormalization.On,
                _ => null,
            };
        }
    }
}