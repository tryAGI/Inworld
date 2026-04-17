
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Audio encoding used for STT input.
    /// </summary>
    public enum SttAudioEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        AutoDetect,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Linear16,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        OggOpus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SttAudioEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttAudioEncoding value)
        {
            return value switch
            {
                SttAudioEncoding.AutoDetect => "AUTO_DETECT",
                SttAudioEncoding.Flac => "FLAC",
                SttAudioEncoding.Linear16 => "LINEAR16",
                SttAudioEncoding.Mp3 => "MP3",
                SttAudioEncoding.OggOpus => "OGG_OPUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttAudioEncoding? ToEnum(string value)
        {
            return value switch
            {
                "AUTO_DETECT" => SttAudioEncoding.AutoDetect,
                "FLAC" => SttAudioEncoding.Flac,
                "LINEAR16" => SttAudioEncoding.Linear16,
                "MP3" => SttAudioEncoding.Mp3,
                "OGG_OPUS" => SttAudioEncoding.OggOpus,
                _ => null,
            };
        }
    }
}