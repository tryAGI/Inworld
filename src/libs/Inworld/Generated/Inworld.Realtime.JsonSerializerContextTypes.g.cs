
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
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.StreamAudioEncoding? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.StreamTimestampType? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.StreamApplyTextNormalization? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.StreamDeliveryMode? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.StreamTimestampTransportStrategy? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.StreamAudioConfig? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.StreamStatus? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsCreateContextParams? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsSendTextParams? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsWordAlignment? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsCharacterAlignment? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsTimestampInfo? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsStreamUsage? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsAudioChunkData? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsResultEnvelope? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttStreamAudioEncoding? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttVoiceProfileConfig? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttGroqConfig? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttAssemblyAiConfig? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttInworldSttV1Config? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttTranscribeConfigParams? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttAudioChunkData? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttWordTimestamp? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttTranscriptionData? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.SttWordTimestamp>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttUsageData? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttSpeechStartedData? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsCreateContext? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsSendText? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsFlushContext? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsCloseContext? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsContextCreated? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsAudioChunk? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsFlushCompleted? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsContextClosed? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttConfigure? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttAudioChunk? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttEndTurn? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttCloseStream? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttTranscriptionResult? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttTranscription? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttUsageResult? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttUsage? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttSpeechStartedResult? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttSpeechStarted? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TextToSpeechStreamServerEvent? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SpeechToTextStreamServerEvent? Type56 { get; set; }

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