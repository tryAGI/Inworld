
#nullable enable

namespace Inworld.Realtime
{
    public sealed partial class InworldUnifiedRealtimeClient
    {
        /// <summary>
        /// Receives updates from the WebSocket connection as an async enumerable.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>An async enumerable of server events.</returns>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Inworld.Realtime.UnifiedServerEvent> ReceiveUpdatesAsync(
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            var buffer = new byte[1024 * 1024]; // 1MB buffer size
            var arraySegment = new global::System.ArraySegment<byte>(buffer);

            while (_clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    yield break;
                }

                using var __messageBuffer = new global::System.IO.MemoryStream();
                var __receivedTextMessage = false;

                while (true)
                {
                    global::System.Net.WebSockets.WebSocketReceiveResult result;

                    try
                    {
                        result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.WebSockets.WebSocketException exception)
                    {
                        RaiseException(exception);
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (await TryReconnectAsync(exception, cancellationToken).ConfigureAwait(false))
                        {
                            continue;
                        }

                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }
                    catch (global::System.OperationCanceledException exception)
                    {
                        if (!cancellationToken.IsCancellationRequested)
                        {
                            RaiseException(exception);
                        }

                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Close)
                    {
                        RaiseClosed(result.CloseStatus, result.CloseStatusDescription);
                        await _clientWebSocket.CloseAsync(
                            closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                            statusDescription: "Closing",
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Text)
                    {
                        __receivedTextMessage = true;

                        if (result.Count > 0)
                        {
                            __messageBuffer.Write(buffer, 0, result.Count);
                        }
                    }

                    if (result.EndOfMessage)
                    {
                        break;
                    }
                }

                if (!__receivedTextMessage)
                {
                    continue;
                }

                string json = global::System.Text.Encoding.UTF8.GetString(__messageBuffer.ToArray());
                    global::Inworld.Realtime.UnifiedServerEvent @event;
                    try
                    {
                        @event = (global::Inworld.Realtime.UnifiedServerEvent)global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::Inworld.Realtime.UnifiedServerEvent), JsonSerializerContext)!;
                    }
                    catch (global::System.Exception exception) when (
                        exception is global::System.Text.Json.JsonException ||
                        exception is global::System.NotSupportedException ||
                        exception is global::System.InvalidOperationException)
                    {
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        DispatchUnknownMessage(json);
                        if (rethrow)
                        {
                            throw;
                        }

                        continue;
                    }

                    DispatchReceivedMessage(@event, json);
                    yield return @event;
            }
        }


        private static global::System.Text.Json.JsonElement? TryParseMessageJson(
            string rawText)
        {
            try
            {
                using var document = global::System.Text.Json.JsonDocument.Parse(rawText);
                return document.RootElement.Clone();
            }
            catch (global::System.Text.Json.JsonException)
            {
                return null;
            }
        }

        private void DispatchUnknownMessage(
            string rawText)
        {
            UnknownMessage?.Invoke(
                this,
                new AutoSDKWebSocketUnknownMessageEventArgs(
                    rawText,
                    TryParseMessageJson(rawText)));
        }

        private void DispatchReceivedMessage(
            global::Inworld.Realtime.UnifiedServerEvent @event,
            string rawText)
        {
            var json = TryParseMessageJson(rawText);
            MessageReceived?.Invoke(
                this,
                new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedServerEvent>(
                    @event,
                    rawText,
                    json));

            if (@event.SessionCreated is { } __UnifiedSessionCreatedReceived)
            {
                UnifiedSessionCreatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedSessionCreated>(
                        __UnifiedSessionCreatedReceived,
                        rawText,
                        json));
            }
            if (@event.SessionUpdated is { } __UnifiedSessionUpdatedReceived)
            {
                UnifiedSessionUpdatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedSessionUpdated>(
                        __UnifiedSessionUpdatedReceived,
                        rawText,
                        json));
            }
            if (@event.Error is { } __UnifiedErrorReceived)
            {
                UnifiedErrorReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedError>(
                        __UnifiedErrorReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemAdded is { } __UnifiedConversationItemAddedReceived)
            {
                UnifiedConversationItemAddedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedConversationItemAdded>(
                        __UnifiedConversationItemAddedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemDone is { } __UnifiedConversationItemDoneReceived)
            {
                UnifiedConversationItemDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedConversationItemDone>(
                        __UnifiedConversationItemDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemDeleted is { } __UnifiedConversationItemDeletedReceived)
            {
                UnifiedConversationItemDeletedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedConversationItemDeleted>(
                        __UnifiedConversationItemDeletedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemRetrieved is { } __UnifiedConversationItemRetrievedReceived)
            {
                UnifiedConversationItemRetrievedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedConversationItemRetrieved>(
                        __UnifiedConversationItemRetrievedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemTruncated is { } __UnifiedConversationItemTruncatedReceived)
            {
                UnifiedConversationItemTruncatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedConversationItemTruncated>(
                        __UnifiedConversationItemTruncatedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemInputAudioTranscriptionDelta is { } __UnifiedConversationItemInputAudioTranscriptionDeltaReceived)
            {
                UnifiedConversationItemInputAudioTranscriptionDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta>(
                        __UnifiedConversationItemInputAudioTranscriptionDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemInputAudioTranscriptionCompleted is { } __UnifiedConversationItemInputAudioTranscriptionCompletedReceived)
            {
                UnifiedConversationItemInputAudioTranscriptionCompletedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted>(
                        __UnifiedConversationItemInputAudioTranscriptionCompletedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseSpeakAcknowledged is { } __UnifiedResponseSpeakAcknowledgedReceived)
            {
                UnifiedResponseSpeakAcknowledgedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged>(
                        __UnifiedResponseSpeakAcknowledgedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseCreated is { } __UnifiedResponseCreatedReceived)
            {
                UnifiedResponseCreatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseCreated>(
                        __UnifiedResponseCreatedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseDone is { } __UnifiedResponseDoneReceived)
            {
                UnifiedResponseDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseDone>(
                        __UnifiedResponseDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputItemAdded is { } __UnifiedResponseOutputItemAddedReceived)
            {
                UnifiedResponseOutputItemAddedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseOutputItemAdded>(
                        __UnifiedResponseOutputItemAddedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputItemDone is { } __UnifiedResponseOutputItemDoneReceived)
            {
                UnifiedResponseOutputItemDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseOutputItemDone>(
                        __UnifiedResponseOutputItemDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseContentPartAdded is { } __UnifiedResponseContentPartAddedReceived)
            {
                UnifiedResponseContentPartAddedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseContentPartAdded>(
                        __UnifiedResponseContentPartAddedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseContentPartDone is { } __UnifiedResponseContentPartDoneReceived)
            {
                UnifiedResponseContentPartDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseContentPartDone>(
                        __UnifiedResponseContentPartDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputTextDelta is { } __UnifiedResponseOutputTextDeltaReceived)
            {
                UnifiedResponseOutputTextDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseOutputTextDelta>(
                        __UnifiedResponseOutputTextDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputTextDone is { } __UnifiedResponseOutputTextDoneReceived)
            {
                UnifiedResponseOutputTextDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseOutputTextDone>(
                        __UnifiedResponseOutputTextDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioTranscriptDelta is { } __UnifiedResponseOutputAudioTranscriptDeltaReceived)
            {
                UnifiedResponseOutputAudioTranscriptDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta>(
                        __UnifiedResponseOutputAudioTranscriptDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioTranscriptDone is { } __UnifiedResponseOutputAudioTranscriptDoneReceived)
            {
                UnifiedResponseOutputAudioTranscriptDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone>(
                        __UnifiedResponseOutputAudioTranscriptDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioDone is { } __UnifiedResponseOutputAudioDoneReceived)
            {
                UnifiedResponseOutputAudioDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseOutputAudioDone>(
                        __UnifiedResponseOutputAudioDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseFunctionCallArgumentsDelta is { } __UnifiedResponseFunctionCallArgumentsDeltaReceived)
            {
                UnifiedResponseFunctionCallArgumentsDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta>(
                        __UnifiedResponseFunctionCallArgumentsDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseFunctionCallArgumentsDone is { } __UnifiedResponseFunctionCallArgumentsDoneReceived)
            {
                UnifiedResponseFunctionCallArgumentsDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone>(
                        __UnifiedResponseFunctionCallArgumentsDoneReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferSpeechStarted is { } __UnifiedInputAudioBufferSpeechStartedReceived)
            {
                UnifiedInputAudioBufferSpeechStartedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted>(
                        __UnifiedInputAudioBufferSpeechStartedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferSpeechStopped is { } __UnifiedInputAudioBufferSpeechStoppedReceived)
            {
                UnifiedInputAudioBufferSpeechStoppedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped>(
                        __UnifiedInputAudioBufferSpeechStoppedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferCommitted is { } __UnifiedInputAudioBufferCommittedReceived)
            {
                UnifiedInputAudioBufferCommittedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedInputAudioBufferCommitted>(
                        __UnifiedInputAudioBufferCommittedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferCleared is { } __UnifiedInputAudioBufferClearedReceived)
            {
                UnifiedInputAudioBufferClearedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedInputAudioBufferCleared>(
                        __UnifiedInputAudioBufferClearedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferTimeoutTriggered is { } __UnifiedInputAudioBufferTimeoutTriggeredReceived)
            {
                UnifiedInputAudioBufferTimeoutTriggeredReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered>(
                        __UnifiedInputAudioBufferTimeoutTriggeredReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferTurnSuggestion is { } __UnifiedInputAudioBufferTurnSuggestionReceived)
            {
                UnifiedInputAudioBufferTurnSuggestionReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion>(
                        __UnifiedInputAudioBufferTurnSuggestionReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferTurnSuggestionRevoked is { } __UnifiedInputAudioBufferTurnSuggestionRevokedReceived)
            {
                UnifiedInputAudioBufferTurnSuggestionRevokedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked>(
                        __UnifiedInputAudioBufferTurnSuggestionRevokedReceived,
                        rawText,
                        json));
            }
            if (@event.OutputAudioBufferStarted is { } __UnifiedOutputAudioBufferStartedReceived)
            {
                UnifiedOutputAudioBufferStartedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedOutputAudioBufferStarted>(
                        __UnifiedOutputAudioBufferStartedReceived,
                        rawText,
                        json));
            }
            if (@event.OutputAudioBufferStopped is { } __UnifiedOutputAudioBufferStoppedReceived)
            {
                UnifiedOutputAudioBufferStoppedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedOutputAudioBufferStopped>(
                        __UnifiedOutputAudioBufferStoppedReceived,
                        rawText,
                        json));
            }
            if (@event.OutputAudioBufferCleared is { } __UnifiedOutputAudioBufferClearedReceived)
            {
                UnifiedOutputAudioBufferClearedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedOutputAudioBufferCleared>(
                        __UnifiedOutputAudioBufferClearedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseBackchannelAudioDelta is { } __UnifiedResponseBackchannelAudioDeltaReceived)
            {
                UnifiedResponseBackchannelAudioDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta>(
                        __UnifiedResponseBackchannelAudioDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseBackchannelAudioDone is { } __UnifiedResponseBackchannelAudioDoneReceived)
            {
                UnifiedResponseBackchannelAudioDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone>(
                        __UnifiedResponseBackchannelAudioDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseBackchannelSkipped is { } __UnifiedResponseBackchannelSkippedReceived)
            {
                UnifiedResponseBackchannelSkippedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseBackchannelSkipped>(
                        __UnifiedResponseBackchannelSkippedReceived,
                        rawText,
                        json));
            }
            if (@event.RateLimitsUpdated is { } __UnifiedRateLimitsUpdatedReceived)
            {
                UnifiedRateLimitsUpdatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedRateLimitsUpdated>(
                        __UnifiedRateLimitsUpdatedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioDelta is { } __UnifiedResponseOutputAudioDeltaReceived)
            {
                UnifiedResponseOutputAudioDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseOutputAudioDelta>(
                        __UnifiedResponseOutputAudioDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseAudioDelta is { } __UnifiedResponseAudioDeltaReceived)
            {
                UnifiedResponseAudioDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseAudioDelta>(
                        __UnifiedResponseAudioDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseAudioDone is { } __UnifiedResponseAudioDoneReceived)
            {
                UnifiedResponseAudioDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseAudioDone>(
                        __UnifiedResponseAudioDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseTextDelta is { } __UnifiedResponseTextDeltaReceived)
            {
                UnifiedResponseTextDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseTextDelta>(
                        __UnifiedResponseTextDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseTextDone is { } __UnifiedResponseTextDoneReceived)
            {
                UnifiedResponseTextDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseTextDone>(
                        __UnifiedResponseTextDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseAudioTranscriptDelta is { } __UnifiedResponseAudioTranscriptDeltaReceived)
            {
                UnifiedResponseAudioTranscriptDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta>(
                        __UnifiedResponseAudioTranscriptDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseAudioTranscriptDone is { } __UnifiedResponseAudioTranscriptDoneReceived)
            {
                UnifiedResponseAudioTranscriptDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone>(
                        __UnifiedResponseAudioTranscriptDoneReceived,
                        rawText,
                        json));
            }
        }
    }
}