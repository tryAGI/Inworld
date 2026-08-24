
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Variation and expressiveness mode for Realtime TTS-2.
    /// </summary>
    public enum DeliveryMode
    {
        /// <summary>
        /// 
        /// </summary>
        Balanced,
        /// <summary>
        /// 
        /// </summary>
        Creative,
        /// <summary>
        /// 
        /// </summary>
        Stable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeliveryModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeliveryMode value)
        {
            return value switch
            {
                DeliveryMode.Balanced => "BALANCED",
                DeliveryMode.Creative => "CREATIVE",
                DeliveryMode.Stable => "STABLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeliveryMode? ToEnum(string value)
        {
            return value switch
            {
                "BALANCED" => DeliveryMode.Balanced,
                "CREATIVE" => DeliveryMode.Creative,
                "STABLE" => DeliveryMode.Stable,
                _ => null,
            };
        }
    }
}