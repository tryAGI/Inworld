
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum SttStreamAudioEncoding
    {
        /// <summary>
        ///
        /// </summary>
        AudioEncodingUnspecified,
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
    public static class SttStreamAudioEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttStreamAudioEncoding value)
        {
            return value switch
            {
                SttStreamAudioEncoding.AudioEncodingUnspecified => "AUDIO_ENCODING_UNSPECIFIED",
                SttStreamAudioEncoding.AutoDetect => "AUTO_DETECT",
                SttStreamAudioEncoding.Flac => "FLAC",
                SttStreamAudioEncoding.Linear16 => "LINEAR16",
                SttStreamAudioEncoding.Mp3 => "MP3",
                SttStreamAudioEncoding.OggOpus => "OGG_OPUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttStreamAudioEncoding? ToEnum(string value)
        {
            return value switch
            {
                "AUDIO_ENCODING_UNSPECIFIED" => SttStreamAudioEncoding.AudioEncodingUnspecified,
                "AUTO_DETECT" => SttStreamAudioEncoding.AutoDetect,
                "FLAC" => SttStreamAudioEncoding.Flac,
                "LINEAR16" => SttStreamAudioEncoding.Linear16,
                "MP3" => SttStreamAudioEncoding.Mp3,
                "OGG_OPUS" => SttStreamAudioEncoding.OggOpus,
                _ => null,
            };
        }
    }
}