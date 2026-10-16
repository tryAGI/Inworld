
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseOutputAudioTranscriptDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputAudioTranscriptDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseOutputAudioTranscriptDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseOutputAudioTranscriptDoneType value)
        {
            return value switch
            {
                UnifiedResponseOutputAudioTranscriptDoneType.ResponseOutputAudioTranscriptDone => "response.output_audio_transcript.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseOutputAudioTranscriptDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio_transcript.done" => UnifiedResponseOutputAudioTranscriptDoneType.ResponseOutputAudioTranscriptDone,
                _ => null,
            };
        }
    }
}