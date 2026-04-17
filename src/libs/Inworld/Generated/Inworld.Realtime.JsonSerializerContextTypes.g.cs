
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.StreamAudioConfig? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.StreamStatus? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsCreateContextParams? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsSendTextParams? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsWordAlignment? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsCharacterAlignment? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsTimestampInfo? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsStreamUsage? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsAudioChunkData? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsResultEnvelope? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttVoiceProfileConfig? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttGroqConfig? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttAssemblyAiConfig? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttInworldSttV1Config? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttTranscribeConfigParams? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttAudioChunkData? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttWordTimestamp? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttTranscriptionData? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.SttWordTimestamp>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttUsageData? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttSpeechStartedData? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsCreateContext? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsSendText? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsFlushContext? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsCloseContext? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsContextCreated? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsAudioChunk? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsFlushCompleted? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsContextClosed? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttConfigure? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttAudioChunk? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttEndTurn? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttCloseStream? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttTranscriptionResult? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttTranscription? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttUsageResult? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttUsage? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttSpeechStartedResult? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SttSpeechStarted? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TextToSpeechStreamServerEvent? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.SpeechToTextStreamServerEvent? Type50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.Realtime.SttWordTimestamp>? ListType3 { get; set; }
    }
}