
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Inworld.Realtime.JsonConverters.StreamAudioEncodingJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.StreamAudioEncodingNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.StreamTimestampTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.StreamTimestampTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.StreamApplyTextNormalizationJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.StreamApplyTextNormalizationNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.StreamDeliveryModeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.StreamDeliveryModeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.StreamTimestampTransportStrategyJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.StreamTimestampTransportStrategyNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.SttStreamAudioEncodingJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.SttStreamAudioEncodingNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedSessionUpdateTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedSessionUpdateTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemCreateTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemCreateTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemTruncateTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemTruncateTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemDeleteTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemDeleteTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemRetrieveTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemRetrieveTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseCreateTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseCreateTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseCancelTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseCancelTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseSpeakTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseSpeakTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferAppendTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferAppendTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferCommitTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferCommitTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferClearTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferClearTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedOutputAudioBufferClearTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedOutputAudioBufferClearTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedSessionCreatedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedSessionCreatedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedSessionUpdatedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedSessionUpdatedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedErrorTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedErrorTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemAddedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemAddedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemDeletedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemDeletedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemRetrievedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemRetrievedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemTruncatedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemTruncatedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemInputAudioTranscriptionDeltaTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemInputAudioTranscriptionDeltaTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemInputAudioTranscriptionCompletedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemInputAudioTranscriptionCompletedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseSpeakAcknowledgedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseSpeakAcknowledgedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseCreatedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseCreatedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputItemAddedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputItemAddedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputItemDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputItemDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseContentPartAddedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseContentPartAddedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseContentPartDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseContentPartDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputTextDeltaTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputTextDeltaTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputTextDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputTextDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputAudioTranscriptDeltaTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputAudioTranscriptDeltaTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputAudioTranscriptDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputAudioTranscriptDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputAudioDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputAudioDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseFunctionCallArgumentsDeltaTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseFunctionCallArgumentsDeltaTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseFunctionCallArgumentsDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseFunctionCallArgumentsDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferSpeechStartedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferSpeechStartedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferSpeechStoppedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferSpeechStoppedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferCommittedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferCommittedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferClearedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferClearedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferTimeoutTriggeredTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferTimeoutTriggeredTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferTurnSuggestionTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferTurnSuggestionTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferTurnSuggestionRevokedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedInputAudioBufferTurnSuggestionRevokedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedOutputAudioBufferStartedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedOutputAudioBufferStartedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedOutputAudioBufferStoppedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedOutputAudioBufferStoppedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedOutputAudioBufferClearedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedOutputAudioBufferClearedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseBackchannelAudioDeltaTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseBackchannelAudioDeltaTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseBackchannelAudioDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseBackchannelAudioDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseBackchannelSkippedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseBackchannelSkippedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedRateLimitsUpdatedTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedRateLimitsUpdatedTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputAudioDeltaTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseOutputAudioDeltaTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseAudioDeltaTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseAudioDeltaTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseAudioDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseAudioDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseTextDeltaTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseTextDeltaTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseTextDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseTextDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseAudioTranscriptDeltaTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseAudioTranscriptDeltaTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseAudioTranscriptDoneTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseAudioTranscriptDoneTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.TextToSpeechStreamServerEventJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.SpeechToTextStreamServerEventJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.UnifiedServerEventJsonConverter),

            typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<int?, string>),

            typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedAudioFormat>),

            typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedAudioFormat>),

            typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedToolChoice>),

            typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedTruncation>),

            typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedTracing>),

            typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<int?, string>),

            typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedToolChoice>),

            typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<int?, string>),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.RealtimeSourceGenerationContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.StreamAudioEncoding), TypeInfoPropertyName = "StreamAudioEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.StreamTimestampType), TypeInfoPropertyName = "StreamTimestampType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.StreamApplyTextNormalization), TypeInfoPropertyName = "StreamApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.StreamDeliveryMode), TypeInfoPropertyName = "StreamDeliveryMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.StreamTimestampTransportStrategy), TypeInfoPropertyName = "StreamTimestampTransportStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.StreamAudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.StreamStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SttStreamAudioEncoding), TypeInfoPropertyName = "SttStreamAudioEncoding2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.OneOf<int?, string>), TypeInfoPropertyName = "OneOfInt32String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedAudioFormat>), TypeInfoPropertyName = "OneOfStringUnifiedAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionAudioInputNoiseReduction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionAudioInputTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedSessionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedToolChoice>), TypeInfoPropertyName = "OneOfStringUnifiedToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedTruncation>), TypeInfoPropertyName = "OneOfStringUnifiedTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedTruncation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedTracing>), TypeInfoPropertyName = "OneOfStringUnifiedTracing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedTracing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedProviderData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedTextGenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedConversationItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOptionsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOptionsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOutputItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputItemContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseUsageInputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseUsageOutputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseUsageLlm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseUsageTts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseUsageStt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedTruncationTokenLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedVoiceProfileLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedVoiceProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedVoiceProfileLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSttProviderData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedTtsProviderData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedMemoryProviderData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedBackchannelProviderData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponsivenessProviderData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedTimestampInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedTimestampInfoWordAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedTimestampInfoCharacterAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedTextGenerationConfigReasoning))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionUpdateType), TypeInfoPropertyName = "UnifiedSessionUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemCreateType), TypeInfoPropertyName = "UnifiedConversationItemCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemTruncateType), TypeInfoPropertyName = "UnifiedConversationItemTruncateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemDeleteType), TypeInfoPropertyName = "UnifiedConversationItemDeleteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemRetrieve))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemRetrieveType), TypeInfoPropertyName = "UnifiedConversationItemRetrieveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseCreateType), TypeInfoPropertyName = "UnifiedResponseCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseCancel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseCancelType), TypeInfoPropertyName = "UnifiedResponseCancelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseSpeakMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseSpeak))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseSpeakType), TypeInfoPropertyName = "UnifiedResponseSpeakType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferAppend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferAppendType), TypeInfoPropertyName = "UnifiedInputAudioBufferAppendType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCommit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCommitType), TypeInfoPropertyName = "UnifiedInputAudioBufferCommitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferClear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferClearType), TypeInfoPropertyName = "UnifiedInputAudioBufferClearType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferClear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferClearType), TypeInfoPropertyName = "UnifiedOutputAudioBufferClearType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionCreatedType), TypeInfoPropertyName = "UnifiedSessionCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedSessionUpdatedType), TypeInfoPropertyName = "UnifiedSessionUpdatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedErrorType), TypeInfoPropertyName = "UnifiedErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemAddedType), TypeInfoPropertyName = "UnifiedConversationItemAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemDoneType), TypeInfoPropertyName = "UnifiedConversationItemDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemDeletedType), TypeInfoPropertyName = "UnifiedConversationItemDeletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemRetrieved))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemRetrievedType), TypeInfoPropertyName = "UnifiedConversationItemRetrievedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemTruncated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemTruncatedType), TypeInfoPropertyName = "UnifiedConversationItemTruncatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDeltaType), TypeInfoPropertyName = "UnifiedConversationItemInputAudioTranscriptionDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompletedType), TypeInfoPropertyName = "UnifiedConversationItemInputAudioTranscriptionCompletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedType), TypeInfoPropertyName = "UnifiedResponseSpeakAcknowledgedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseCreatedType), TypeInfoPropertyName = "UnifiedResponseCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseDoneType), TypeInfoPropertyName = "UnifiedResponseDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputItemAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputItemAddedType), TypeInfoPropertyName = "UnifiedResponseOutputItemAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputItemDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputItemDoneType), TypeInfoPropertyName = "UnifiedResponseOutputItemDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseContentPartAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseContentPartAddedType), TypeInfoPropertyName = "UnifiedResponseContentPartAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseContentPartDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseContentPartDoneType), TypeInfoPropertyName = "UnifiedResponseContentPartDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDeltaType), TypeInfoPropertyName = "UnifiedResponseOutputTextDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDoneType), TypeInfoPropertyName = "UnifiedResponseOutputTextDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDeltaType), TypeInfoPropertyName = "UnifiedResponseOutputAudioTranscriptDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDoneType), TypeInfoPropertyName = "UnifiedResponseOutputAudioTranscriptDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDoneType), TypeInfoPropertyName = "UnifiedResponseOutputAudioDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDeltaType), TypeInfoPropertyName = "UnifiedResponseFunctionCallArgumentsDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDoneType), TypeInfoPropertyName = "UnifiedResponseFunctionCallArgumentsDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStartedType), TypeInfoPropertyName = "UnifiedInputAudioBufferSpeechStartedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStoppedType), TypeInfoPropertyName = "UnifiedInputAudioBufferSpeechStoppedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCommitted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCommittedType), TypeInfoPropertyName = "UnifiedInputAudioBufferCommittedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCleared))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferClearedType), TypeInfoPropertyName = "UnifiedInputAudioBufferClearedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggeredType), TypeInfoPropertyName = "UnifiedInputAudioBufferTimeoutTriggeredType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionType), TypeInfoPropertyName = "UnifiedInputAudioBufferTurnSuggestionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevokedType), TypeInfoPropertyName = "UnifiedInputAudioBufferTurnSuggestionRevokedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStartedType), TypeInfoPropertyName = "UnifiedOutputAudioBufferStartedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStopped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStoppedType), TypeInfoPropertyName = "UnifiedOutputAudioBufferStoppedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferCleared))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferClearedType), TypeInfoPropertyName = "UnifiedOutputAudioBufferClearedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDeltaType), TypeInfoPropertyName = "UnifiedResponseBackchannelAudioDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDoneType), TypeInfoPropertyName = "UnifiedResponseBackchannelAudioDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelSkipped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelSkippedType), TypeInfoPropertyName = "UnifiedResponseBackchannelSkippedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedRateLimitsUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedRateLimitsUpdatedType), TypeInfoPropertyName = "UnifiedRateLimitsUpdatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDeltaType), TypeInfoPropertyName = "UnifiedResponseOutputAudioDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseAudioDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseAudioDeltaType), TypeInfoPropertyName = "UnifiedResponseAudioDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseAudioDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseAudioDoneType), TypeInfoPropertyName = "UnifiedResponseAudioDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseTextDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseTextDeltaType), TypeInfoPropertyName = "UnifiedResponseTextDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseTextDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseTextDoneType), TypeInfoPropertyName = "UnifiedResponseTextDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDeltaType), TypeInfoPropertyName = "UnifiedResponseAudioTranscriptDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDoneType), TypeInfoPropertyName = "UnifiedResponseAudioTranscriptDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.TextToSpeechStreamServerEvent), TypeInfoPropertyName = "TextToSpeechStreamServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.SpeechToTextStreamServerEvent), TypeInfoPropertyName = "SpeechToTextStreamServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedServerEvent), TypeInfoPropertyName = "UnifiedServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Realtime.UnifiedServerEventDiscriminatorType), TypeInfoPropertyName = "UnifiedServerEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Realtime.SttWordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedSessionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedConversationItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedResponseOptionsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedResponseOutputItemContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Realtime.UnifiedVoiceProfileLabel>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}