
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// Variation and expressiveness mode for Realtime TTS-2.
    /// </summary>
    public enum StreamDeliveryMode
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
    public static class StreamDeliveryModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamDeliveryMode value)
        {
            return value switch
            {
                StreamDeliveryMode.Balanced => "BALANCED",
                StreamDeliveryMode.Creative => "CREATIVE",
                StreamDeliveryMode.Stable => "STABLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamDeliveryMode? ToEnum(string value)
        {
            return value switch
            {
                "BALANCED" => StreamDeliveryMode.Balanced,
                "CREATIVE" => StreamDeliveryMode.Creative,
                "STABLE" => StreamDeliveryMode.Stable,
                _ => null,
            };
        }
    }
}