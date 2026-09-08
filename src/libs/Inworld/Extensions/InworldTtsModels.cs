#nullable enable

namespace Inworld;

/// <summary>Canonical Inworld text-to-speech model identifiers.</summary>
public static class InworldTtsModels
{
    /// <summary>The flagship GA model for maximum quality, steering, and professional voice clones.</summary>
    public const string RealtimeTts2 = "inworld-tts-2";

    /// <summary>The GA model optimized for the lowest latency, cost, and high-volume workloads.</summary>
    public const string RealtimeTts2Flash = "inworld-tts-2-flash";

    /// <summary>A deprecated previous-generation model retained for compatibility.</summary>
    public const string RealtimeTts15Max = "inworld-tts-1.5-max";

    /// <summary>A deprecated previous-generation model retained for compatibility.</summary>
    public const string RealtimeTts15Mini = "inworld-tts-1.5-mini";
}
