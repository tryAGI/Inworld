
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Audio container/encoding used for TTS output.
    /// </summary>
    public enum AudioEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Alaw,
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
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        OggOpus,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioEncoding value)
        {
            return value switch
            {
                AudioEncoding.Alaw => "ALAW",
                AudioEncoding.Flac => "FLAC",
                AudioEncoding.Linear16 => "LINEAR16",
                AudioEncoding.Mp3 => "MP3",
                AudioEncoding.Mulaw => "MULAW",
                AudioEncoding.OggOpus => "OGG_OPUS",
                AudioEncoding.Pcm => "PCM",
                AudioEncoding.Wav => "WAV",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioEncoding? ToEnum(string value)
        {
            return value switch
            {
                "ALAW" => AudioEncoding.Alaw,
                "FLAC" => AudioEncoding.Flac,
                "LINEAR16" => AudioEncoding.Linear16,
                "MP3" => AudioEncoding.Mp3,
                "MULAW" => AudioEncoding.Mulaw,
                "OGG_OPUS" => AudioEncoding.OggOpus,
                "PCM" => AudioEncoding.Pcm,
                "WAV" => AudioEncoding.Wav,
                _ => null,
            };
        }
    }
}