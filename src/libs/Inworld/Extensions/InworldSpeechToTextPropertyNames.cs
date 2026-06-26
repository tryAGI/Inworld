#nullable enable

namespace Inworld;

/// <summary>
/// Additional property keys used by the Inworld MEAI speech-to-text adapter.
/// </summary>
public static class InworldSpeechToTextPropertyNames
{
    /// <summary>
    /// Additional property key for streaming <c>audioEncoding</c>.
    /// </summary>
    public const string AudioEncoding = "audioEncoding";

    /// <summary>
    /// Additional property key for streaming <c>sampleRateHertz</c>.
    /// </summary>
    public const string SampleRateHertz = "sampleRateHertz";

    /// <summary>
    /// Additional property key for streaming <c>numberOfChannels</c>.
    /// </summary>
    public const string NumberOfChannels = "numberOfChannels";

    /// <summary>
    /// Additional property key for streaming <c>inactivityTimeoutSeconds</c>.
    /// </summary>
    public const string InactivityTimeoutSeconds = "inactivityTimeoutSeconds";

    /// <summary>
    /// Additional property key for streaming <c>endOfTurnConfidenceThreshold</c>.
    /// </summary>
    public const string EndOfTurnConfidenceThreshold = "endOfTurnConfidenceThreshold";

    /// <summary>
    /// Additional property key for streaming <c>prompts</c>.
    /// </summary>
    public const string Prompts = "prompts";

    /// <summary>
    /// Additional property key for streaming <c>includeWordTimestamps</c>.
    /// </summary>
    public const string IncludeWordTimestamps = "includeWordTimestamps";

    /// <summary>
    /// Additional property key for generated streaming <c>groqConfig</c>.
    /// </summary>
    public const string GroqConfig = "groqConfig";

    /// <summary>
    /// Additional property key for generated streaming <c>assemblyaiConfig</c>.
    /// </summary>
    public const string AssemblyAiConfig = "assemblyaiConfig";

    /// <summary>
    /// Additional property key for generated streaming <c>inworldSttV1Config</c>.
    /// </summary>
    public const string InworldSttV1Config = "inworldSttV1Config";

    /// <summary>
    /// Additional property key for generated streaming <c>voiceProfileConfig</c>.
    /// </summary>
    public const string VoiceProfileConfig = "voiceProfileConfig";

    /// <summary>
    /// Additional property key for the <c>voiceProfileConfig.enableVoiceProfile</c> shortcut.
    /// </summary>
    public const string EnableVoiceProfile = "enableVoiceProfile";

    /// <summary>
    /// Additional property key that sends an <c>end_turn</c> control message before closing the stream.
    /// </summary>
    public const string SendEndTurn = "sendEndTurn";
}
