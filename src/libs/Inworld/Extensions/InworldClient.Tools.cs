#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Inworld;

/// <summary>
/// Extensions for using InworldClient as MEAI AIFunction tools with any IChatClient.
/// </summary>
public static class InworldClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that synthesizes speech from text and returns
    /// Base64-encoded audio plus metadata.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsSynthesizeSpeechTool(this InworldClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The text to synthesize. Max 2,000 characters.")] string text,
                [Description("Voice identifier (e.g. 'Dennis' or 'Alice'). Use list_voices to discover.")] string voiceId,
                [Description("Model identifier. Defaults to 'inworld-tts-1.5-max'.")] string? modelId,
                [Description("Sampling temperature. Range (0, 2]. Defaults to 1.0.")] double? temperature,
                CancellationToken cancellationToken) =>
            {
                var response = await client.TextToSpeech.SynthesizeSpeechAsync(
                    text: text,
                    voiceId: voiceId,
                    modelId: modelId is { Length: > 0 } ? modelId : "inworld-tts-1.5-max",
                    temperature: temperature,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    AudioBytesBase64 = response.AudioContent,
                    ProcessedCharacters = response.Usage?.ProcessedCharactersCount,
                    ModelUsed = response.Usage?.ModelId,
                };
            },
            name: "Inworld_SynthesizeSpeech",
            description: "Synthesize natural-sounding speech from text using an Inworld voice. Returns Base64-encoded audio bytes.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists available Inworld voices, optionally
    /// filtered by language.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsListVoicesTool(this InworldClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Optional language code filter (e.g. EN_US, JA_JP, ES_ES). Omit to list all.")] string? language,
                CancellationToken cancellationToken) =>
            {
                var languages = language is { Length: > 0 } l
                    ? new List<LangCode> { LangCodeExtensions.ToEnum(l) ?? LangCode.EnUs }
                    : null;

                var response = await client.Voices.ListVoicesAsync(
                    languages: languages,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Voices = (response.Voices ?? new List<Voice>())
                        .Select(v => new
                        {
                            v.VoiceId,
                            v.DisplayName,
                            v.Description,
                            LangCode = v.LangCode?.ToValueString(),
                            Source = v.Source?.ToValueString(),
                            v.Tags,
                        })
                        .ToList(),
                };
            },
            name: "Inworld_ListVoices",
            description: "List voices available in the Inworld workspace, optionally filtered by language.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists available LLM models supported by
    /// the Inworld LLM Router.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsListModelsTool(this InworldClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Models.ListModelsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Models = (response.Models ?? new List<Model>())
                        .Select(m => new
                        {
                            Id = m.Model1,
                            m.Provider,
                            m.ModelCreator,
                            ContextLength = m.Spec?.ContextLength,
                            MaxCompletionTokens = m.Spec?.MaxCompletionTokens,
                            SupportsFunctions = m.Spec?.Capabilities?.FunctionCalling,
                            SupportsVision = m.Spec?.Capabilities?.Vision,
                            SupportsReasoning = m.Spec?.Capabilities?.Reasoning,
                            PromptPrice = m.Pricing?.Prompt,
                            CompletionPrice = m.Pricing?.Completion,
                        })
                        .ToList(),
                };
            },
            name: "Inworld_ListModels",
            description: "List all LLM models supported by the Inworld LLM Router with their capabilities, context length, and pricing.");
    }

    /// <summary>
    /// Creates an AIFunction tool that generates candidate voice previews from
    /// a text description.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsDesignVoiceTool(this InworldClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("English description of the desired voice. 30–250 characters.")] string designPrompt,
                [Description("Text to speak in the generated preview. Should produce 1–15 seconds of audio.")] string previewText,
                [Description("Target language code (e.g. EN_US, JA_JP, ES_ES). Defaults to EN_US.")] string? language,
                [Description("Number of preview voices to generate (1–3). Defaults to 1.")] int? numberOfSamples,
                CancellationToken cancellationToken) =>
            {
                var langCode = language is { Length: > 0 } l
                    ? (LangCodeExtensions.ToEnum(l) ?? LangCode.EnUs)
                    : LangCode.EnUs;

                var response = await client.Voices.DesignVoiceAsync(
                    new DesignVoiceRequest
                    {
                        LangCode = langCode,
                        DesignPrompt = designPrompt,
                        PreviewText = previewText,
                        VoiceDesignConfig = numberOfSamples is int n
                            ? new VoiceDesignConfig { NumberOfSamples = n }
                            : null,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.LangCode,
                    PreviewVoices = (response.PreviewVoices ?? new List<PreviewVoice>())
                        .Select(v => new
                        {
                            v.VoiceId,
                            v.PreviewText,
                            AudioBytesBase64 = v.PreviewAudio,
                        })
                        .ToList(),
                };
            },
            name: "Inworld_DesignVoice",
            description: "Generate candidate voice previews from a text description. Previews can later be promoted via Publish Voice.");
    }
}
