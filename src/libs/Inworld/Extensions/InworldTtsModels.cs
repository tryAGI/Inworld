#nullable enable

namespace Inworld;

/// <summary>Canonical Inworld text-to-speech model identifiers.</summary>
public static class InworldTtsModels
{
    /// <summary>The latest expressive model, currently in research preview.</summary>
    public const string RealtimeTts2 = "inworld-tts-2";

    /// <summary>The flagship production model.</summary>
    public const string RealtimeTts15Max = "inworld-tts-1.5-max";

    /// <summary>The lowest-latency production model.</summary>
    public const string RealtimeTts15Mini = "inworld-tts-1.5-mini";
}
