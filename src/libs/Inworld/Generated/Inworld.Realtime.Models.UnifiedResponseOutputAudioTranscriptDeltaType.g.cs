
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseOutputAudioTranscriptDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputAudioTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseOutputAudioTranscriptDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseOutputAudioTranscriptDeltaType value)
        {
            return value switch
            {
                UnifiedResponseOutputAudioTranscriptDeltaType.ResponseOutputAudioTranscriptDelta => "response.output_audio_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseOutputAudioTranscriptDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio_transcript.delta" => UnifiedResponseOutputAudioTranscriptDeltaType.ResponseOutputAudioTranscriptDelta,
                _ => null,
            };
        }
    }
}