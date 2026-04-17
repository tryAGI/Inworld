
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Timestamp granularity returned alongside TTS audio.
    /// </summary>
    public enum TimestampType
    {
        /// <summary>
        /// 
        /// </summary>
        Character,
        /// <summary>
        /// 
        /// </summary>
        TimestampTypeUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimestampTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimestampType value)
        {
            return value switch
            {
                TimestampType.Character => "CHARACTER",
                TimestampType.TimestampTypeUnspecified => "TIMESTAMP_TYPE_UNSPECIFIED",
                TimestampType.Word => "WORD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimestampType? ToEnum(string value)
        {
            return value switch
            {
                "CHARACTER" => TimestampType.Character,
                "TIMESTAMP_TYPE_UNSPECIFIED" => TimestampType.TimestampTypeUnspecified,
                "WORD" => TimestampType.Word,
                _ => null,
            };
        }
    }
}