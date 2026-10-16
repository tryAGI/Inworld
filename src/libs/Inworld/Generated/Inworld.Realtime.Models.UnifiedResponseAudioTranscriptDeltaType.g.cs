
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedResponseAudioTranscriptDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseAudioTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedResponseAudioTranscriptDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedResponseAudioTranscriptDeltaType value)
        {
            return value switch
            {
                UnifiedResponseAudioTranscriptDeltaType.ResponseAudioTranscriptDelta => "response.audio_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedResponseAudioTranscriptDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio_transcript.delta" => UnifiedResponseAudioTranscriptDeltaType.ResponseAudioTranscriptDelta,
                _ => null,
            };
        }
    }
}