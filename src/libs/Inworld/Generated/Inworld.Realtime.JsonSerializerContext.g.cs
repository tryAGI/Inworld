
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Inworld.Realtime.JsonConverters.TextToSpeechStreamServerEventJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.SpeechToTextStreamServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.StreamAudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.StreamStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsCreateContextParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsSendTextParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsWordAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsCharacterAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsTimestampInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsStreamUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsAudioChunkData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsResultEnvelope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttVoiceProfileConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttGroqConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttAssemblyAiConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttInworldSttV1Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttTranscribeConfigParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttAudioChunkData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttWordTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttTranscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.Realtime.SttWordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttUsageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttSpeechStartedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsCreateContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsSendText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsFlushContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsCloseContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsContextCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsAudioChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsFlushCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TtsContextClosed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttConfigure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttAudioChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttEndTurn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttCloseStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttTranscriptionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttUsageResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttSpeechStartedResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttSpeechStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TextToSpeechStreamServerEvent), TypeInfoPropertyName = "TextToSpeechStreamServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SpeechToTextStreamServerEvent), TypeInfoPropertyName = "SpeechToTextStreamServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Realtime.SttWordTimestamp>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}