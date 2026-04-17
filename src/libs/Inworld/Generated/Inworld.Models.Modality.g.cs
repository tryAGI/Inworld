
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Supported input/output modality for a model.
    /// </summary>
    public enum Modality
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Modality value)
        {
            return value switch
            {
                Modality.Audio => "audio",
                Modality.Image => "image",
                Modality.Text => "text",
                Modality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Modality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => Modality.Audio,
                "image" => Modality.Image,
                "text" => Modality.Text,
                "video" => Modality.Video,
                _ => null,
            };
        }
    }
}