
#nullable enable

namespace Inworld
{
    /// <summary>
    /// How the voice-design prompt is interpreted.
    /// </summary>
    public enum DesignPromptMode
    {
        /// <summary>
        ///
        /// </summary>
        Assisted,
        /// <summary>
        ///
        /// </summary>
        Verbatim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DesignPromptModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DesignPromptMode value)
        {
            return value switch
            {
                DesignPromptMode.Assisted => "DESIGN_PROMPT_MODE_ASSISTED",
                DesignPromptMode.Verbatim => "DESIGN_PROMPT_MODE_VERBATIM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DesignPromptMode? ToEnum(string value)
        {
            return value switch
            {
                "DESIGN_PROMPT_MODE_ASSISTED" => DesignPromptMode.Assisted,
                "DESIGN_PROMPT_MODE_VERBATIM" => DesignPromptMode.Verbatim,
                _ => null,
            };
        }
    }
}