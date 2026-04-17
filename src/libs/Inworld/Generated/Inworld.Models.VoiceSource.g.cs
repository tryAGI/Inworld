
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Origin of the voice.
    /// </summary>
    public enum VoiceSource
    {
        /// <summary>
        /// 
        /// </summary>
        Ivc,
        /// <summary>
        /// 
        /// </summary>
        Pvc,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSource value)
        {
            return value switch
            {
                VoiceSource.Ivc => "IVC",
                VoiceSource.Pvc => "PVC",
                VoiceSource.System => "SYSTEM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSource? ToEnum(string value)
        {
            return value switch
            {
                "IVC" => VoiceSource.Ivc,
                "PVC" => VoiceSource.Pvc,
                "SYSTEM" => VoiceSource.System,
                _ => null,
            };
        }
    }
}