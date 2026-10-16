#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Inworld.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class UnifiedServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inworld.Realtime.UnifiedServerEvent>
    {
        /// <inheritdoc />
        public override global::Inworld.Realtime.UnifiedServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Inworld.Realtime.UnifiedSessionCreated? sessionCreated = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.SessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedSessionCreated)}");
                sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedSessionUpdated? sessionUpdated = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.SessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedSessionUpdated)}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedError? error = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedConversationItemAdded? conversationItemAdded = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ConversationItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedConversationItemAdded)}");
                conversationItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedConversationItemDone? conversationItemDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ConversationItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedConversationItemDone)}");
                conversationItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedConversationItemDeleted? conversationItemDeleted = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedConversationItemDeleted)}");
                conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedConversationItemRetrieved? conversationItemRetrieved = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ConversationItemRetrieved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemRetrieved> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedConversationItemRetrieved)}");
                conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedConversationItemTruncated? conversationItemTruncated = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemTruncated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedConversationItemTruncated)}");
                conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta)}");
                conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted)}");
                conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged? responseSpeakAcknowledged = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseSpeakAcknowledged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged)}");
                responseSpeakAcknowledged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseCreated? responseCreated = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseCreated)}");
                responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseDone? responseDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseDone)}");
                responseDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseOutputItemAdded? responseOutputItemAdded = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseOutputItemAdded)}");
                responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseOutputItemDone? responseOutputItemDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseOutputItemDone)}");
                responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseContentPartAdded? responseContentPartAdded = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseContentPartAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseContentPartAdded)}");
                responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseContentPartDone? responseContentPartDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseContentPartDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseContentPartDone)}");
                responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseOutputTextDelta? responseOutputTextDelta = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseOutputTextDelta)}");
                responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseOutputTextDone? responseOutputTextDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseOutputTextDone)}");
                responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta? responseOutputAudioTranscriptDelta = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta)}");
                responseOutputAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone? responseOutputAudioTranscriptDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone)}");
                responseOutputAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseOutputAudioDone? responseOutputAudioDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseOutputAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputAudioDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseOutputAudioDone)}");
                responseOutputAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta)}");
                responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone)}");
                responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.InputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted)}");
                inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.InputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped)}");
                inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedInputAudioBufferCommitted? inputAudioBufferCommitted = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.InputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferCommitted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedInputAudioBufferCommitted)}");
                inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedInputAudioBufferCleared? inputAudioBufferCleared = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.InputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedInputAudioBufferCleared)}");
                inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered? inputAudioBufferTimeoutTriggered = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.InputAudioBufferTimeoutTriggered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered)}");
                inputAudioBufferTimeoutTriggered = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion? inputAudioBufferTurnSuggestion = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.InputAudioBufferTurnSuggestion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion)}");
                inputAudioBufferTurnSuggestion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked? inputAudioBufferTurnSuggestionRevoked = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.InputAudioBufferTurnSuggestionRevoked)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked)}");
                inputAudioBufferTurnSuggestionRevoked = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedOutputAudioBufferStarted? outputAudioBufferStarted = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.OutputAudioBufferStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedOutputAudioBufferStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedOutputAudioBufferStarted)}");
                outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedOutputAudioBufferStopped? outputAudioBufferStopped = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.OutputAudioBufferStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedOutputAudioBufferStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedOutputAudioBufferStopped)}");
                outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedOutputAudioBufferCleared? outputAudioBufferCleared = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.OutputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedOutputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedOutputAudioBufferCleared)}");
                outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta? responseBackchannelAudioDelta = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseBackchannelAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta)}");
                responseBackchannelAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone? responseBackchannelAudioDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseBackchannelAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone)}");
                responseBackchannelAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseBackchannelSkipped? responseBackchannelSkipped = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseBackchannelSkipped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelSkipped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseBackchannelSkipped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseBackchannelSkipped)}");
                responseBackchannelSkipped = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedRateLimitsUpdated? rateLimitsUpdated = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.RateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedRateLimitsUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedRateLimitsUpdated)}");
                rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseOutputAudioDelta? responseOutputAudioDelta = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseOutputAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseOutputAudioDelta)}");
                responseOutputAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseAudioDelta? responseAudioDelta = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseAudioDelta)}");
                responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseAudioDone? responseAudioDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseAudioDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseAudioDone)}");
                responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseTextDelta? responseTextDelta = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseTextDelta)}");
                responseTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseTextDone? responseTextDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseTextDone)}");
                responseTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta? responseAudioTranscriptDelta = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta)}");
                responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone? responseAudioTranscriptDone = default;
            if (discriminator?.Type == global::Inworld.Realtime.UnifiedServerEventDiscriminatorType.ResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone)}");
                responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Inworld.Realtime.UnifiedServerEvent(
                discriminator?.Type,
                sessionCreated,

                sessionUpdated,

                error,

                conversationItemAdded,

                conversationItemDone,

                conversationItemDeleted,

                conversationItemRetrieved,

                conversationItemTruncated,

                conversationItemInputAudioTranscriptionDelta,

                conversationItemInputAudioTranscriptionCompleted,

                responseSpeakAcknowledged,

                responseCreated,

                responseDone,

                responseOutputItemAdded,

                responseOutputItemDone,

                responseContentPartAdded,

                responseContentPartDone,

                responseOutputTextDelta,

                responseOutputTextDone,

                responseOutputAudioTranscriptDelta,

                responseOutputAudioTranscriptDone,

                responseOutputAudioDone,

                responseFunctionCallArgumentsDelta,

                responseFunctionCallArgumentsDone,

                inputAudioBufferSpeechStarted,

                inputAudioBufferSpeechStopped,

                inputAudioBufferCommitted,

                inputAudioBufferCleared,

                inputAudioBufferTimeoutTriggered,

                inputAudioBufferTurnSuggestion,

                inputAudioBufferTurnSuggestionRevoked,

                outputAudioBufferStarted,

                outputAudioBufferStopped,

                outputAudioBufferCleared,

                responseBackchannelAudioDelta,

                responseBackchannelAudioDone,

                responseBackchannelSkipped,

                rateLimitsUpdated,

                responseOutputAudioDelta,

                responseAudioDelta,

                responseAudioDone,

                responseTextDelta,

                responseTextDone,

                responseAudioTranscriptDelta,

                responseAudioTranscriptDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Inworld.Realtime.UnifiedServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedSessionCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedSessionCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionCreated(), typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionUpdated(), typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickError(), typeInfo);
            }
            else if (value.IsConversationItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedConversationItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConversationItemAdded(), typeInfo);
            }
            else if (value.IsConversationItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedConversationItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConversationItemDone(), typeInfo);
            }
            else if (value.IsConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedConversationItemDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConversationItemDeleted(), typeInfo);
            }
            else if (value.IsConversationItemRetrieved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemRetrieved?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedConversationItemRetrieved).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConversationItemRetrieved(), typeInfo);
            }
            else if (value.IsConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemTruncated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedConversationItemTruncated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConversationItemTruncated(), typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConversationItemInputAudioTranscriptionDelta(), typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConversationItemInputAudioTranscriptionCompleted(), typeInfo);
            }
            else if (value.IsResponseSpeakAcknowledged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseSpeakAcknowledged(), typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseCreated(), typeInfo);
            }
            else if (value.IsResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseDone(), typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputItemAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseOutputItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputItemAdded(), typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputItemDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseOutputItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputItemDone(), typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseContentPartAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseContentPartAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseContentPartAdded(), typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseContentPartDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseContentPartDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseContentPartDone(), typeInfo);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputTextDelta(), typeInfo);
            }
            else if (value.IsResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputTextDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputTextDone(), typeInfo);
            }
            else if (value.IsResponseOutputAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputAudioTranscriptDelta(), typeInfo);
            }
            else if (value.IsResponseOutputAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputAudioTranscriptDone(), typeInfo);
            }
            else if (value.IsResponseOutputAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputAudioDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputAudioDone(), typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFunctionCallArgumentsDelta(), typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFunctionCallArgumentsDone(), typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputAudioBufferSpeechStarted(), typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputAudioBufferSpeechStopped(), typeInfo);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferCommitted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCommitted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputAudioBufferCommitted(), typeInfo);
            }
            else if (value.IsInputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputAudioBufferCleared(), typeInfo);
            }
            else if (value.IsInputAudioBufferTimeoutTriggered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputAudioBufferTimeoutTriggered(), typeInfo);
            }
            else if (value.IsInputAudioBufferTurnSuggestion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputAudioBufferTurnSuggestion(), typeInfo);
            }
            else if (value.IsInputAudioBufferTurnSuggestionRevoked)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputAudioBufferTurnSuggestionRevoked(), typeInfo);
            }
            else if (value.IsOutputAudioBufferStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedOutputAudioBufferStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOutputAudioBufferStarted(), typeInfo);
            }
            else if (value.IsOutputAudioBufferStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedOutputAudioBufferStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOutputAudioBufferStopped(), typeInfo);
            }
            else if (value.IsOutputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedOutputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOutputAudioBufferCleared(), typeInfo);
            }
            else if (value.IsResponseBackchannelAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseBackchannelAudioDelta(), typeInfo);
            }
            else if (value.IsResponseBackchannelAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseBackchannelAudioDone(), typeInfo);
            }
            else if (value.IsResponseBackchannelSkipped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseBackchannelSkipped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseBackchannelSkipped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseBackchannelSkipped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseBackchannelSkipped(), typeInfo);
            }
            else if (value.IsRateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedRateLimitsUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedRateLimitsUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRateLimitsUpdated(), typeInfo);
            }
            else if (value.IsResponseOutputAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseOutputAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputAudioDelta(), typeInfo);
            }
            else if (value.IsResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseAudioDelta(), typeInfo);
            }
            else if (value.IsResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseAudioDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseAudioDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseAudioDone(), typeInfo);
            }
            else if (value.IsResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseTextDelta(), typeInfo);
            }
            else if (value.IsResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseTextDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseTextDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseTextDone(), typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseAudioTranscriptDelta(), typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseAudioTranscriptDone(), typeInfo);
            }
        }
    }
}