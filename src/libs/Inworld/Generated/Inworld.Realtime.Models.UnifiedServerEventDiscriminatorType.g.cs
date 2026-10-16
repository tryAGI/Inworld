
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum UnifiedServerEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ConversationItemAdded,
        /// <summary>
        ///
        /// </summary>
        ConversationItemDeleted,
        /// <summary>
        ///
        /// </summary>
        ConversationItemDone,
        /// <summary>
        ///
        /// </summary>
        ConversationItemInputAudioTranscriptionCompleted,
        /// <summary>
        ///
        /// </summary>
        ConversationItemInputAudioTranscriptionDelta,
        /// <summary>
        ///
        /// </summary>
        ConversationItemRetrieved,
        /// <summary>
        ///
        /// </summary>
        ConversationItemTruncated,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferCleared,
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferCommitted,
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferSpeechStarted,
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferSpeechStopped,
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferTimeoutTriggered,
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferTurnSuggestion,
        /// <summary>
        ///
        /// </summary>
        InputAudioBufferTurnSuggestionRevoked,
        /// <summary>
        ///
        /// </summary>
        OutputAudioBufferCleared,
        /// <summary>
        ///
        /// </summary>
        OutputAudioBufferStarted,
        /// <summary>
        ///
        /// </summary>
        OutputAudioBufferStopped,
        /// <summary>
        ///
        /// </summary>
        RateLimitsUpdated,
        /// <summary>
        ///
        /// </summary>
        ResponseAudioDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseAudioDone,
        /// <summary>
        ///
        /// </summary>
        ResponseAudioTranscriptDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseAudioTranscriptDone,
        /// <summary>
        ///
        /// </summary>
        ResponseBackchannelAudioDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseBackchannelAudioDone,
        /// <summary>
        ///
        /// </summary>
        ResponseBackchannelSkipped,
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartDone,
        /// <summary>
        ///
        /// </summary>
        ResponseCreated,
        /// <summary>
        ///
        /// </summary>
        ResponseDone,
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDone,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputAudioDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputAudioDone,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputAudioTranscriptDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputAudioTranscriptDone,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemDone,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDone,
        /// <summary>
        ///
        /// </summary>
        ResponseSpeakAcknowledged,
        /// <summary>
        ///
        /// </summary>
        ResponseTextDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseTextDone,
        /// <summary>
        ///
        /// </summary>
        SessionCreated,
        /// <summary>
        ///
        /// </summary>
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedServerEventDiscriminatorType value)
        {
            return value switch
            {
                UnifiedServerEventDiscriminatorType.ConversationItemAdded => "conversation.item.added",
                UnifiedServerEventDiscriminatorType.ConversationItemDeleted => "conversation.item.deleted",
                UnifiedServerEventDiscriminatorType.ConversationItemDone => "conversation.item.done",
                UnifiedServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                UnifiedServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta => "conversation.item.input_audio_transcription.delta",
                UnifiedServerEventDiscriminatorType.ConversationItemRetrieved => "conversation.item.retrieved",
                UnifiedServerEventDiscriminatorType.ConversationItemTruncated => "conversation.item.truncated",
                UnifiedServerEventDiscriminatorType.Error => "error",
                UnifiedServerEventDiscriminatorType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                UnifiedServerEventDiscriminatorType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                UnifiedServerEventDiscriminatorType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                UnifiedServerEventDiscriminatorType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                UnifiedServerEventDiscriminatorType.InputAudioBufferTimeoutTriggered => "input_audio_buffer.timeout_triggered",
                UnifiedServerEventDiscriminatorType.InputAudioBufferTurnSuggestion => "input_audio_buffer.turn_suggestion",
                UnifiedServerEventDiscriminatorType.InputAudioBufferTurnSuggestionRevoked => "input_audio_buffer.turn_suggestion_revoked",
                UnifiedServerEventDiscriminatorType.OutputAudioBufferCleared => "output_audio_buffer.cleared",
                UnifiedServerEventDiscriminatorType.OutputAudioBufferStarted => "output_audio_buffer.started",
                UnifiedServerEventDiscriminatorType.OutputAudioBufferStopped => "output_audio_buffer.stopped",
                UnifiedServerEventDiscriminatorType.RateLimitsUpdated => "rate_limits.updated",
                UnifiedServerEventDiscriminatorType.ResponseAudioDelta => "response.audio.delta",
                UnifiedServerEventDiscriminatorType.ResponseAudioDone => "response.audio.done",
                UnifiedServerEventDiscriminatorType.ResponseAudioTranscriptDelta => "response.audio_transcript.delta",
                UnifiedServerEventDiscriminatorType.ResponseAudioTranscriptDone => "response.audio_transcript.done",
                UnifiedServerEventDiscriminatorType.ResponseBackchannelAudioDelta => "response.backchannel.audio.delta",
                UnifiedServerEventDiscriminatorType.ResponseBackchannelAudioDone => "response.backchannel.audio.done",
                UnifiedServerEventDiscriminatorType.ResponseBackchannelSkipped => "response.backchannel.skipped",
                UnifiedServerEventDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                UnifiedServerEventDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                UnifiedServerEventDiscriminatorType.ResponseCreated => "response.created",
                UnifiedServerEventDiscriminatorType.ResponseDone => "response.done",
                UnifiedServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                UnifiedServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                UnifiedServerEventDiscriminatorType.ResponseOutputAudioDelta => "response.output_audio.delta",
                UnifiedServerEventDiscriminatorType.ResponseOutputAudioDone => "response.output_audio.done",
                UnifiedServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta => "response.output_audio_transcript.delta",
                UnifiedServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone => "response.output_audio_transcript.done",
                UnifiedServerEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                UnifiedServerEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                UnifiedServerEventDiscriminatorType.ResponseOutputTextDelta => "response.output_text.delta",
                UnifiedServerEventDiscriminatorType.ResponseOutputTextDone => "response.output_text.done",
                UnifiedServerEventDiscriminatorType.ResponseSpeakAcknowledged => "response.speak.acknowledged",
                UnifiedServerEventDiscriminatorType.ResponseTextDelta => "response.text.delta",
                UnifiedServerEventDiscriminatorType.ResponseTextDone => "response.text.done",
                UnifiedServerEventDiscriminatorType.SessionCreated => "session.created",
                UnifiedServerEventDiscriminatorType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.added" => UnifiedServerEventDiscriminatorType.ConversationItemAdded,
                "conversation.item.deleted" => UnifiedServerEventDiscriminatorType.ConversationItemDeleted,
                "conversation.item.done" => UnifiedServerEventDiscriminatorType.ConversationItemDone,
                "conversation.item.input_audio_transcription.completed" => UnifiedServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted,
                "conversation.item.input_audio_transcription.delta" => UnifiedServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta,
                "conversation.item.retrieved" => UnifiedServerEventDiscriminatorType.ConversationItemRetrieved,
                "conversation.item.truncated" => UnifiedServerEventDiscriminatorType.ConversationItemTruncated,
                "error" => UnifiedServerEventDiscriminatorType.Error,
                "input_audio_buffer.cleared" => UnifiedServerEventDiscriminatorType.InputAudioBufferCleared,
                "input_audio_buffer.committed" => UnifiedServerEventDiscriminatorType.InputAudioBufferCommitted,
                "input_audio_buffer.speech_started" => UnifiedServerEventDiscriminatorType.InputAudioBufferSpeechStarted,
                "input_audio_buffer.speech_stopped" => UnifiedServerEventDiscriminatorType.InputAudioBufferSpeechStopped,
                "input_audio_buffer.timeout_triggered" => UnifiedServerEventDiscriminatorType.InputAudioBufferTimeoutTriggered,
                "input_audio_buffer.turn_suggestion" => UnifiedServerEventDiscriminatorType.InputAudioBufferTurnSuggestion,
                "input_audio_buffer.turn_suggestion_revoked" => UnifiedServerEventDiscriminatorType.InputAudioBufferTurnSuggestionRevoked,
                "output_audio_buffer.cleared" => UnifiedServerEventDiscriminatorType.OutputAudioBufferCleared,
                "output_audio_buffer.started" => UnifiedServerEventDiscriminatorType.OutputAudioBufferStarted,
                "output_audio_buffer.stopped" => UnifiedServerEventDiscriminatorType.OutputAudioBufferStopped,
                "rate_limits.updated" => UnifiedServerEventDiscriminatorType.RateLimitsUpdated,
                "response.audio.delta" => UnifiedServerEventDiscriminatorType.ResponseAudioDelta,
                "response.audio.done" => UnifiedServerEventDiscriminatorType.ResponseAudioDone,
                "response.audio_transcript.delta" => UnifiedServerEventDiscriminatorType.ResponseAudioTranscriptDelta,
                "response.audio_transcript.done" => UnifiedServerEventDiscriminatorType.ResponseAudioTranscriptDone,
                "response.backchannel.audio.delta" => UnifiedServerEventDiscriminatorType.ResponseBackchannelAudioDelta,
                "response.backchannel.audio.done" => UnifiedServerEventDiscriminatorType.ResponseBackchannelAudioDone,
                "response.backchannel.skipped" => UnifiedServerEventDiscriminatorType.ResponseBackchannelSkipped,
                "response.content_part.added" => UnifiedServerEventDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => UnifiedServerEventDiscriminatorType.ResponseContentPartDone,
                "response.created" => UnifiedServerEventDiscriminatorType.ResponseCreated,
                "response.done" => UnifiedServerEventDiscriminatorType.ResponseDone,
                "response.function_call_arguments.delta" => UnifiedServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => UnifiedServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.output_audio.delta" => UnifiedServerEventDiscriminatorType.ResponseOutputAudioDelta,
                "response.output_audio.done" => UnifiedServerEventDiscriminatorType.ResponseOutputAudioDone,
                "response.output_audio_transcript.delta" => UnifiedServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta,
                "response.output_audio_transcript.done" => UnifiedServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone,
                "response.output_item.added" => UnifiedServerEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => UnifiedServerEventDiscriminatorType.ResponseOutputItemDone,
                "response.output_text.delta" => UnifiedServerEventDiscriminatorType.ResponseOutputTextDelta,
                "response.output_text.done" => UnifiedServerEventDiscriminatorType.ResponseOutputTextDone,
                "response.speak.acknowledged" => UnifiedServerEventDiscriminatorType.ResponseSpeakAcknowledged,
                "response.text.delta" => UnifiedServerEventDiscriminatorType.ResponseTextDelta,
                "response.text.done" => UnifiedServerEventDiscriminatorType.ResponseTextDone,
                "session.created" => UnifiedServerEventDiscriminatorType.SessionCreated,
                "session.updated" => UnifiedServerEventDiscriminatorType.SessionUpdated,
                _ => null,
            };
        }
    }
}