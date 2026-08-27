
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum StreamAudioEncoding
    {
        /// <summary>
        ///
        /// </summary>
        Alaw,
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
    public static class StreamAudioEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamAudioEncoding value)
        {
            return value switch
            {
                StreamAudioEncoding.Alaw => "ALAW",
                StreamAudioEncoding.Linear16 => "LINEAR16",
                StreamAudioEncoding.Mp3 => "MP3",
                StreamAudioEncoding.Mulaw => "MULAW",
                StreamAudioEncoding.OggOpus => "OGG_OPUS",
                StreamAudioEncoding.Pcm => "PCM",
                StreamAudioEncoding.Wav => "WAV",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamAudioEncoding? ToEnum(string value)
        {
            return value switch
            {
                "ALAW" => StreamAudioEncoding.Alaw,
                "LINEAR16" => StreamAudioEncoding.Linear16,
                "MP3" => StreamAudioEncoding.Mp3,
                "MULAW" => StreamAudioEncoding.Mulaw,
                "OGG_OPUS" => StreamAudioEncoding.OggOpus,
                "PCM" => StreamAudioEncoding.Pcm,
                "WAV" => StreamAudioEncoding.Wav,
                _ => null,
            };
        }
    }
}