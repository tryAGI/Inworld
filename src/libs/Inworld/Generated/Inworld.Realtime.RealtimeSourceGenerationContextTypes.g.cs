
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSourceGenerationContextTypes
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::Inworld.Realtime.UnifiedSession? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.OneOf<int?, string>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionAudio? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionAudioInput? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedAudioFormat>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedAudioFormat? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionAudioInputNoiseReduction? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionAudioInputTranscription? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedTurnDetection? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionAudioOutput? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedSessionTool>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionTool? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedToolChoice>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedToolChoice? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedTruncation>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedTruncation? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedTracing>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedTracing? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedProviderData? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedTextGenerationConfig? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItem? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedConversationItemContentItem>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemContentItem? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOptions? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOptionsTool>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOptionsTool? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponse? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOutputItem>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputItem? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOutputItemContentItem>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputItemContentItem? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseUsage? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseUsageInputTokenDetails? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseUsageOutputTokenDetails? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseUsageLlm? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseUsageTts? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseUsageStt? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedContentPart? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedTruncationTokenLimits? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedVoiceProfileLabel? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedVoiceProfile? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSttProviderData? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedTtsProviderData? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedMemoryProviderData? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedBackchannelProviderData? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponsivenessProviderData? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedTimestampInfo? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedTimestampInfoWordAlignment? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedTimestampInfoCharacterAlignment? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedTextGenerationConfigReasoning? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsCreateContext? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsSendText? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsFlushContext? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsCloseContext? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsContextCreated? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsAudioChunk? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsFlushCompleted? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TtsContextClosed? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttConfigure? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttAudioChunk? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttEndTurn? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttCloseStream? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttTranscriptionResult? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttTranscription? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttUsageResult? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttUsage? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttSpeechStartedResult? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SttSpeechStarted? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionUpdate? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionUpdateType? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemCreate? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemCreateType? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemTruncate? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemTruncateType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemDelete? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemDeleteType? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemRetrieve? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemRetrieveType? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseCreate? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseCreateType? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseCancel? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseCancelType? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseSpeakMetadata? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseSpeak? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseSpeakType? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferAppend? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferAppendType? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferCommit? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferCommitType? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferClear? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferClearType? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedOutputAudioBufferClear? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedOutputAudioBufferClearType? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionCreated? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionCreatedType? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionUpdated? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionUpdatedType? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedErrorError? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedError? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedErrorType? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemAdded? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemAddedType? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemDone? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemDoneType? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemDeleted? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemDeletedType? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemRetrieved? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemRetrievedType? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemTruncated? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemTruncatedType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDeltaType? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompletedType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedMetadata? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedError? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedType? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseCreated? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseCreatedType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseDone? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseDoneType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputItemAdded? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputItemAddedType? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputItemDone? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputItemDoneType? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseContentPartAdded? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseContentPartAddedType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseContentPartDone? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseContentPartDoneType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputTextDelta? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputTextDeltaType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputTextDone? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputTextDoneType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDeltaType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDoneType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioDone? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioDoneType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDeltaType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDoneType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStartedType? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStoppedType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferCommitted? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferCommittedType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferCleared? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferClearedType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggeredType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevokedType? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedOutputAudioBufferStarted? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedOutputAudioBufferStartedType? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedOutputAudioBufferStopped? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedOutputAudioBufferStoppedType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedOutputAudioBufferCleared? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedOutputAudioBufferClearedType? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDeltaType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDoneType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseBackchannelSkipped? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseBackchannelSkippedType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedRateLimitsUpdated? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedRateLimitsUpdatedType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioDelta? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioDeltaType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioDelta? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioDeltaType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioDone? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioDoneType? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseTextDelta? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseTextDeltaType? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseTextDone? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseTextDoneType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioTranscriptDeltaType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioTranscriptDoneType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.TextToSpeechStreamServerEvent? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.SpeechToTextStreamServerEvent? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedServerEvent? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedServerEventDiscriminator? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedServerEventDiscriminatorType? Type229 { get; set; }

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
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedSessionTool>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedConversationItemContentItem>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedResponseOptionsTool>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedResponseOutputItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedResponseOutputItemContentItem>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedVoiceProfileLabel>? ListType9 { get; set; }
    }
}