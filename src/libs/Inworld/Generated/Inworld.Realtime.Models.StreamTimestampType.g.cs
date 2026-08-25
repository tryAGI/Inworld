
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamTimestampType
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
    public static class StreamTimestampTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamTimestampType value)
        {
            return value switch
            {
                StreamTimestampType.Character => "CHARACTER",
                StreamTimestampType.TimestampTypeUnspecified => "TIMESTAMP_TYPE_UNSPECIFIED",
                StreamTimestampType.Word => "WORD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamTimestampType? ToEnum(string value)
        {
            return value switch
            {
                "CHARACTER" => StreamTimestampType.Character,
                "TIMESTAMP_TYPE_UNSPECIFIED" => StreamTimestampType.TimestampTypeUnspecified,
                "WORD" => StreamTimestampType.Word,
                _ => null,
            };
        }
    }
}