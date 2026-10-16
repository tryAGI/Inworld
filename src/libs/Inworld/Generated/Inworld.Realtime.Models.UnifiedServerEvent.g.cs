#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UnifiedServerEvent : global::System.IEquatable<UnifiedServerEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedServerEventDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedSessionCreated? SessionCreated { get; init; }
#else
        public global::Inworld.Realtime.UnifiedSessionCreated? SessionCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreated))]
#endif
        public bool IsSessionCreated => SessionCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedSessionCreated? value)
        {
            value = SessionCreated;
            return IsSessionCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionCreated PickSessionCreated() => SessionCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionCreated' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedSessionUpdated? SessionUpdated { get; init; }
#else
        public global::Inworld.Realtime.UnifiedSessionUpdated? SessionUpdated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdated))]
#endif
        public bool IsSessionUpdated => SessionUpdated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedSessionUpdated? value)
        {
            value = SessionUpdated;
            return IsSessionUpdated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedSessionUpdated PickSessionUpdated() => SessionUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUpdated' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedError? Error { get; init; }
#else
        public global::Inworld.Realtime.UnifiedError? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedError PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedConversationItemAdded? ConversationItemAdded { get; init; }
#else
        public global::Inworld.Realtime.UnifiedConversationItemAdded? ConversationItemAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemAdded))]
#endif
        public bool IsConversationItemAdded => ConversationItemAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedConversationItemAdded? value)
        {
            value = ConversationItemAdded;
            return IsConversationItemAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemAdded PickConversationItemAdded() => ConversationItemAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemAdded' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedConversationItemDone? ConversationItemDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedConversationItemDone? ConversationItemDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemDone))]
#endif
        public bool IsConversationItemDone => ConversationItemDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationItemDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedConversationItemDone? value)
        {
            value = ConversationItemDone;
            return IsConversationItemDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemDone PickConversationItemDone() => ConversationItemDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedConversationItemDeleted? ConversationItemDeleted { get; init; }
#else
        public global::Inworld.Realtime.UnifiedConversationItemDeleted? ConversationItemDeleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemDeleted))]
#endif
        public bool IsConversationItemDeleted => ConversationItemDeleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationItemDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedConversationItemDeleted? value)
        {
            value = ConversationItemDeleted;
            return IsConversationItemDeleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemDeleted PickConversationItemDeleted() => ConversationItemDeleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemDeleted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedConversationItemRetrieved? ConversationItemRetrieved { get; init; }
#else
        public global::Inworld.Realtime.UnifiedConversationItemRetrieved? ConversationItemRetrieved { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemRetrieved))]
#endif
        public bool IsConversationItemRetrieved => ConversationItemRetrieved != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationItemRetrieved(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedConversationItemRetrieved? value)
        {
            value = ConversationItemRetrieved;
            return IsConversationItemRetrieved;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemRetrieved PickConversationItemRetrieved() => ConversationItemRetrieved is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemRetrieved' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedConversationItemTruncated? ConversationItemTruncated { get; init; }
#else
        public global::Inworld.Realtime.UnifiedConversationItemTruncated? ConversationItemTruncated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemTruncated))]
#endif
        public bool IsConversationItemTruncated => ConversationItemTruncated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationItemTruncated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedConversationItemTruncated? value)
        {
            value = ConversationItemTruncated;
            return IsConversationItemTruncated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemTruncated PickConversationItemTruncated() => ConversationItemTruncated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemTruncated' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta? ConversationItemInputAudioTranscriptionDelta { get; init; }
#else
        public global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta? ConversationItemInputAudioTranscriptionDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionDelta))]
#endif
        public bool IsConversationItemInputAudioTranscriptionDelta => ConversationItemInputAudioTranscriptionDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationItemInputAudioTranscriptionDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta? value)
        {
            value = ConversationItemInputAudioTranscriptionDelta;
            return IsConversationItemInputAudioTranscriptionDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta PickConversationItemInputAudioTranscriptionDelta() => ConversationItemInputAudioTranscriptionDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemInputAudioTranscriptionDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted? ConversationItemInputAudioTranscriptionCompleted { get; init; }
#else
        public global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted? ConversationItemInputAudioTranscriptionCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionCompleted))]
#endif
        public bool IsConversationItemInputAudioTranscriptionCompleted => ConversationItemInputAudioTranscriptionCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationItemInputAudioTranscriptionCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted? value)
        {
            value = ConversationItemInputAudioTranscriptionCompleted;
            return IsConversationItemInputAudioTranscriptionCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted PickConversationItemInputAudioTranscriptionCompleted() => ConversationItemInputAudioTranscriptionCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemInputAudioTranscriptionCompleted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged? ResponseSpeakAcknowledged { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged? ResponseSpeakAcknowledged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseSpeakAcknowledged))]
#endif
        public bool IsResponseSpeakAcknowledged => ResponseSpeakAcknowledged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseSpeakAcknowledged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged? value)
        {
            value = ResponseSpeakAcknowledged;
            return IsResponseSpeakAcknowledged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged PickResponseSpeakAcknowledged() => ResponseSpeakAcknowledged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseSpeakAcknowledged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseCreated? ResponseCreated { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseCreated? ResponseCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreated))]
#endif
        public bool IsResponseCreated => ResponseCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseCreated? value)
        {
            value = ResponseCreated;
            return IsResponseCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseCreated PickResponseCreated() => ResponseCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCreated' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseDone? ResponseDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseDone? ResponseDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseDone))]
#endif
        public bool IsResponseDone => ResponseDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseDone? value)
        {
            value = ResponseDone;
            return IsResponseDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseDone PickResponseDone() => ResponseDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseOutputItemAdded? ResponseOutputItemAdded { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseOutputItemAdded? ResponseOutputItemAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemAdded))]
#endif
        public bool IsResponseOutputItemAdded => ResponseOutputItemAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseOutputItemAdded? value)
        {
            value = ResponseOutputItemAdded;
            return IsResponseOutputItemAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputItemAdded PickResponseOutputItemAdded() => ResponseOutputItemAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemAdded' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseOutputItemDone? ResponseOutputItemDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseOutputItemDone? ResponseOutputItemDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemDone))]
#endif
        public bool IsResponseOutputItemDone => ResponseOutputItemDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputItemDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseOutputItemDone? value)
        {
            value = ResponseOutputItemDone;
            return IsResponseOutputItemDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputItemDone PickResponseOutputItemDone() => ResponseOutputItemDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseContentPartAdded? ResponseContentPartAdded { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseContentPartAdded? ResponseContentPartAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartAdded))]
#endif
        public bool IsResponseContentPartAdded => ResponseContentPartAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseContentPartAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseContentPartAdded? value)
        {
            value = ResponseContentPartAdded;
            return IsResponseContentPartAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseContentPartAdded PickResponseContentPartAdded() => ResponseContentPartAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartAdded' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseContentPartDone? ResponseContentPartDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseContentPartDone? ResponseContentPartDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartDone))]
#endif
        public bool IsResponseContentPartDone => ResponseContentPartDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseContentPartDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseContentPartDone? value)
        {
            value = ResponseContentPartDone;
            return IsResponseContentPartDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseContentPartDone PickResponseContentPartDone() => ResponseContentPartDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseOutputTextDelta? ResponseOutputTextDelta { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseOutputTextDelta? ResponseOutputTextDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDelta))]
#endif
        public bool IsResponseOutputTextDelta => ResponseOutputTextDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseOutputTextDelta? value)
        {
            value = ResponseOutputTextDelta;
            return IsResponseOutputTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputTextDelta PickResponseOutputTextDelta() => ResponseOutputTextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseOutputTextDone? ResponseOutputTextDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseOutputTextDone? ResponseOutputTextDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDone))]
#endif
        public bool IsResponseOutputTextDone => ResponseOutputTextDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseOutputTextDone? value)
        {
            value = ResponseOutputTextDone;
            return IsResponseOutputTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputTextDone PickResponseOutputTextDone() => ResponseOutputTextDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta? ResponseOutputAudioTranscriptDelta { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta? ResponseOutputAudioTranscriptDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioTranscriptDelta))]
#endif
        public bool IsResponseOutputAudioTranscriptDelta => ResponseOutputAudioTranscriptDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputAudioTranscriptDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta? value)
        {
            value = ResponseOutputAudioTranscriptDelta;
            return IsResponseOutputAudioTranscriptDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta PickResponseOutputAudioTranscriptDelta() => ResponseOutputAudioTranscriptDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioTranscriptDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone? ResponseOutputAudioTranscriptDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone? ResponseOutputAudioTranscriptDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioTranscriptDone))]
#endif
        public bool IsResponseOutputAudioTranscriptDone => ResponseOutputAudioTranscriptDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputAudioTranscriptDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone? value)
        {
            value = ResponseOutputAudioTranscriptDone;
            return IsResponseOutputAudioTranscriptDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone PickResponseOutputAudioTranscriptDone() => ResponseOutputAudioTranscriptDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioTranscriptDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseOutputAudioDone? ResponseOutputAudioDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseOutputAudioDone? ResponseOutputAudioDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioDone))]
#endif
        public bool IsResponseOutputAudioDone => ResponseOutputAudioDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputAudioDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseOutputAudioDone? value)
        {
            value = ResponseOutputAudioDone;
            return IsResponseOutputAudioDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioDone PickResponseOutputAudioDone() => ResponseOutputAudioDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta? ResponseFunctionCallArgumentsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDelta))]
#endif
        public bool IsResponseFunctionCallArgumentsDelta => ResponseFunctionCallArgumentsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta? value)
        {
            value = ResponseFunctionCallArgumentsDelta;
            return IsResponseFunctionCallArgumentsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta PickResponseFunctionCallArgumentsDelta() => ResponseFunctionCallArgumentsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone? ResponseFunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDone))]
#endif
        public bool IsResponseFunctionCallArgumentsDone => ResponseFunctionCallArgumentsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone? value)
        {
            value = ResponseFunctionCallArgumentsDone;
            return IsResponseFunctionCallArgumentsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone PickResponseFunctionCallArgumentsDone() => ResponseFunctionCallArgumentsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted? InputAudioBufferSpeechStarted { get; init; }
#else
        public global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted? InputAudioBufferSpeechStarted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStarted))]
#endif
        public bool IsInputAudioBufferSpeechStarted => InputAudioBufferSpeechStarted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputAudioBufferSpeechStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted? value)
        {
            value = InputAudioBufferSpeechStarted;
            return IsInputAudioBufferSpeechStarted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted PickInputAudioBufferSpeechStarted() => InputAudioBufferSpeechStarted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferSpeechStarted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped? InputAudioBufferSpeechStopped { get; init; }
#else
        public global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped? InputAudioBufferSpeechStopped { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStopped))]
#endif
        public bool IsInputAudioBufferSpeechStopped => InputAudioBufferSpeechStopped != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputAudioBufferSpeechStopped(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped? value)
        {
            value = InputAudioBufferSpeechStopped;
            return IsInputAudioBufferSpeechStopped;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped PickInputAudioBufferSpeechStopped() => InputAudioBufferSpeechStopped is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferSpeechStopped' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedInputAudioBufferCommitted? InputAudioBufferCommitted { get; init; }
#else
        public global::Inworld.Realtime.UnifiedInputAudioBufferCommitted? InputAudioBufferCommitted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCommitted))]
#endif
        public bool IsInputAudioBufferCommitted => InputAudioBufferCommitted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputAudioBufferCommitted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedInputAudioBufferCommitted? value)
        {
            value = InputAudioBufferCommitted;
            return IsInputAudioBufferCommitted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferCommitted PickInputAudioBufferCommitted() => InputAudioBufferCommitted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferCommitted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedInputAudioBufferCleared? InputAudioBufferCleared { get; init; }
#else
        public global::Inworld.Realtime.UnifiedInputAudioBufferCleared? InputAudioBufferCleared { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCleared))]
#endif
        public bool IsInputAudioBufferCleared => InputAudioBufferCleared != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputAudioBufferCleared(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedInputAudioBufferCleared? value)
        {
            value = InputAudioBufferCleared;
            return IsInputAudioBufferCleared;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferCleared PickInputAudioBufferCleared() => InputAudioBufferCleared is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferCleared' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered? InputAudioBufferTimeoutTriggered { get; init; }
#else
        public global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered? InputAudioBufferTimeoutTriggered { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferTimeoutTriggered))]
#endif
        public bool IsInputAudioBufferTimeoutTriggered => InputAudioBufferTimeoutTriggered != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputAudioBufferTimeoutTriggered(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered? value)
        {
            value = InputAudioBufferTimeoutTriggered;
            return IsInputAudioBufferTimeoutTriggered;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered PickInputAudioBufferTimeoutTriggered() => InputAudioBufferTimeoutTriggered is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferTimeoutTriggered' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion? InputAudioBufferTurnSuggestion { get; init; }
#else
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion? InputAudioBufferTurnSuggestion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferTurnSuggestion))]
#endif
        public bool IsInputAudioBufferTurnSuggestion => InputAudioBufferTurnSuggestion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputAudioBufferTurnSuggestion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion? value)
        {
            value = InputAudioBufferTurnSuggestion;
            return IsInputAudioBufferTurnSuggestion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion PickInputAudioBufferTurnSuggestion() => InputAudioBufferTurnSuggestion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferTurnSuggestion' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked? InputAudioBufferTurnSuggestionRevoked { get; init; }
#else
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked? InputAudioBufferTurnSuggestionRevoked { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferTurnSuggestionRevoked))]
#endif
        public bool IsInputAudioBufferTurnSuggestionRevoked => InputAudioBufferTurnSuggestionRevoked != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputAudioBufferTurnSuggestionRevoked(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked? value)
        {
            value = InputAudioBufferTurnSuggestionRevoked;
            return IsInputAudioBufferTurnSuggestionRevoked;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked PickInputAudioBufferTurnSuggestionRevoked() => InputAudioBufferTurnSuggestionRevoked is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferTurnSuggestionRevoked' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedOutputAudioBufferStarted? OutputAudioBufferStarted { get; init; }
#else
        public global::Inworld.Realtime.UnifiedOutputAudioBufferStarted? OutputAudioBufferStarted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAudioBufferStarted))]
#endif
        public bool IsOutputAudioBufferStarted => OutputAudioBufferStarted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputAudioBufferStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedOutputAudioBufferStarted? value)
        {
            value = OutputAudioBufferStarted;
            return IsOutputAudioBufferStarted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedOutputAudioBufferStarted PickOutputAudioBufferStarted() => OutputAudioBufferStarted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputAudioBufferStarted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedOutputAudioBufferStopped? OutputAudioBufferStopped { get; init; }
#else
        public global::Inworld.Realtime.UnifiedOutputAudioBufferStopped? OutputAudioBufferStopped { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAudioBufferStopped))]
#endif
        public bool IsOutputAudioBufferStopped => OutputAudioBufferStopped != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputAudioBufferStopped(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedOutputAudioBufferStopped? value)
        {
            value = OutputAudioBufferStopped;
            return IsOutputAudioBufferStopped;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedOutputAudioBufferStopped PickOutputAudioBufferStopped() => OutputAudioBufferStopped is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputAudioBufferStopped' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedOutputAudioBufferCleared? OutputAudioBufferCleared { get; init; }
#else
        public global::Inworld.Realtime.UnifiedOutputAudioBufferCleared? OutputAudioBufferCleared { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAudioBufferCleared))]
#endif
        public bool IsOutputAudioBufferCleared => OutputAudioBufferCleared != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputAudioBufferCleared(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedOutputAudioBufferCleared? value)
        {
            value = OutputAudioBufferCleared;
            return IsOutputAudioBufferCleared;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedOutputAudioBufferCleared PickOutputAudioBufferCleared() => OutputAudioBufferCleared is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputAudioBufferCleared' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta? ResponseBackchannelAudioDelta { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta? ResponseBackchannelAudioDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseBackchannelAudioDelta))]
#endif
        public bool IsResponseBackchannelAudioDelta => ResponseBackchannelAudioDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseBackchannelAudioDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta? value)
        {
            value = ResponseBackchannelAudioDelta;
            return IsResponseBackchannelAudioDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta PickResponseBackchannelAudioDelta() => ResponseBackchannelAudioDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseBackchannelAudioDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone? ResponseBackchannelAudioDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone? ResponseBackchannelAudioDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseBackchannelAudioDone))]
#endif
        public bool IsResponseBackchannelAudioDone => ResponseBackchannelAudioDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseBackchannelAudioDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone? value)
        {
            value = ResponseBackchannelAudioDone;
            return IsResponseBackchannelAudioDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone PickResponseBackchannelAudioDone() => ResponseBackchannelAudioDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseBackchannelAudioDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseBackchannelSkipped? ResponseBackchannelSkipped { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseBackchannelSkipped? ResponseBackchannelSkipped { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseBackchannelSkipped))]
#endif
        public bool IsResponseBackchannelSkipped => ResponseBackchannelSkipped != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseBackchannelSkipped(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseBackchannelSkipped? value)
        {
            value = ResponseBackchannelSkipped;
            return IsResponseBackchannelSkipped;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseBackchannelSkipped PickResponseBackchannelSkipped() => ResponseBackchannelSkipped is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseBackchannelSkipped' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedRateLimitsUpdated? RateLimitsUpdated { get; init; }
#else
        public global::Inworld.Realtime.UnifiedRateLimitsUpdated? RateLimitsUpdated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RateLimitsUpdated))]
#endif
        public bool IsRateLimitsUpdated => RateLimitsUpdated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRateLimitsUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedRateLimitsUpdated? value)
        {
            value = RateLimitsUpdated;
            return IsRateLimitsUpdated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedRateLimitsUpdated PickRateLimitsUpdated() => RateLimitsUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RateLimitsUpdated' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseOutputAudioDelta? ResponseOutputAudioDelta { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseOutputAudioDelta? ResponseOutputAudioDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioDelta))]
#endif
        public bool IsResponseOutputAudioDelta => ResponseOutputAudioDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputAudioDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseOutputAudioDelta? value)
        {
            value = ResponseOutputAudioDelta;
            return IsResponseOutputAudioDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseOutputAudioDelta PickResponseOutputAudioDelta() => ResponseOutputAudioDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseAudioDelta? ResponseAudioDelta { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseAudioDelta? ResponseAudioDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDelta))]
#endif
        public bool IsResponseAudioDelta => ResponseAudioDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseAudioDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseAudioDelta? value)
        {
            value = ResponseAudioDelta;
            return IsResponseAudioDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioDelta PickResponseAudioDelta() => ResponseAudioDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseAudioDone? ResponseAudioDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseAudioDone? ResponseAudioDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDone))]
#endif
        public bool IsResponseAudioDone => ResponseAudioDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseAudioDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseAudioDone? value)
        {
            value = ResponseAudioDone;
            return IsResponseAudioDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioDone PickResponseAudioDone() => ResponseAudioDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseTextDelta? ResponseTextDelta { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseTextDelta? ResponseTextDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseTextDelta))]
#endif
        public bool IsResponseTextDelta => ResponseTextDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseTextDelta? value)
        {
            value = ResponseTextDelta;
            return IsResponseTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseTextDelta PickResponseTextDelta() => ResponseTextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseTextDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseTextDone? ResponseTextDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseTextDone? ResponseTextDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseTextDone))]
#endif
        public bool IsResponseTextDone => ResponseTextDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseTextDone? value)
        {
            value = ResponseTextDone;
            return IsResponseTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseTextDone PickResponseTextDone() => ResponseTextDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseTextDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta? ResponseAudioTranscriptDelta { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta? ResponseAudioTranscriptDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDelta))]
#endif
        public bool IsResponseAudioTranscriptDelta => ResponseAudioTranscriptDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseAudioTranscriptDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta? value)
        {
            value = ResponseAudioTranscriptDelta;
            return IsResponseAudioTranscriptDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta PickResponseAudioTranscriptDelta() => ResponseAudioTranscriptDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioTranscriptDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone? ResponseAudioTranscriptDone { get; init; }
#else
        public global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone? ResponseAudioTranscriptDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDone))]
#endif
        public bool IsResponseAudioTranscriptDone => ResponseAudioTranscriptDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseAudioTranscriptDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone? value)
        {
            value = ResponseAudioTranscriptDone;
            return IsResponseAudioTranscriptDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone PickResponseAudioTranscriptDone() => ResponseAudioTranscriptDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioTranscriptDone' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedSessionCreated value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedSessionCreated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedSessionCreated?(UnifiedServerEvent @this) => @this.SessionCreated;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedSessionCreated? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromSessionCreated(global::Inworld.Realtime.UnifiedSessionCreated? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedSessionUpdated value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedSessionUpdated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedSessionUpdated?(UnifiedServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedSessionUpdated? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromSessionUpdated(global::Inworld.Realtime.UnifiedSessionUpdated? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedError value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedError?(UnifiedServerEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedError? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromError(global::Inworld.Realtime.UnifiedError? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemAdded value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedConversationItemAdded?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedConversationItemAdded?(UnifiedServerEvent @this) => @this.ConversationItemAdded;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemAdded? value)
        {
            ConversationItemAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromConversationItemAdded(global::Inworld.Realtime.UnifiedConversationItemAdded? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedConversationItemDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedConversationItemDone?(UnifiedServerEvent @this) => @this.ConversationItemDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemDone? value)
        {
            ConversationItemDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromConversationItemDone(global::Inworld.Realtime.UnifiedConversationItemDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemDeleted value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedConversationItemDeleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedConversationItemDeleted?(UnifiedServerEvent @this) => @this.ConversationItemDeleted;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemDeleted? value)
        {
            ConversationItemDeleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromConversationItemDeleted(global::Inworld.Realtime.UnifiedConversationItemDeleted? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemRetrieved value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedConversationItemRetrieved?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedConversationItemRetrieved?(UnifiedServerEvent @this) => @this.ConversationItemRetrieved;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemRetrieved? value)
        {
            ConversationItemRetrieved = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromConversationItemRetrieved(global::Inworld.Realtime.UnifiedConversationItemRetrieved? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemTruncated value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedConversationItemTruncated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedConversationItemTruncated?(UnifiedServerEvent @this) => @this.ConversationItemTruncated;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemTruncated? value)
        {
            ConversationItemTruncated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromConversationItemTruncated(global::Inworld.Realtime.UnifiedConversationItemTruncated? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta?(UnifiedServerEvent @this) => @this.ConversationItemInputAudioTranscriptionDelta;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta? value)
        {
            ConversationItemInputAudioTranscriptionDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromConversationItemInputAudioTranscriptionDelta(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted?(UnifiedServerEvent @this) => @this.ConversationItemInputAudioTranscriptionCompleted;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted? value)
        {
            ConversationItemInputAudioTranscriptionCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromConversationItemInputAudioTranscriptionCompleted(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged?(UnifiedServerEvent @this) => @this.ResponseSpeakAcknowledged;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged? value)
        {
            ResponseSpeakAcknowledged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseSpeakAcknowledged(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseCreated value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseCreated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseCreated?(UnifiedServerEvent @this) => @this.ResponseCreated;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseCreated? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseCreated(global::Inworld.Realtime.UnifiedResponseCreated? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseDone?(UnifiedServerEvent @this) => @this.ResponseDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseDone? value)
        {
            ResponseDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseDone(global::Inworld.Realtime.UnifiedResponseDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputItemAdded value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseOutputItemAdded?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseOutputItemAdded?(UnifiedServerEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputItemAdded? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseOutputItemAdded(global::Inworld.Realtime.UnifiedResponseOutputItemAdded? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputItemDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseOutputItemDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseOutputItemDone?(UnifiedServerEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputItemDone? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseOutputItemDone(global::Inworld.Realtime.UnifiedResponseOutputItemDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseContentPartAdded value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseContentPartAdded?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseContentPartAdded?(UnifiedServerEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseContentPartAdded? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseContentPartAdded(global::Inworld.Realtime.UnifiedResponseContentPartAdded? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseContentPartDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseContentPartDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseContentPartDone?(UnifiedServerEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseContentPartDone? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseContentPartDone(global::Inworld.Realtime.UnifiedResponseContentPartDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputTextDelta value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseOutputTextDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseOutputTextDelta?(UnifiedServerEvent @this) => @this.ResponseOutputTextDelta;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputTextDelta? value)
        {
            ResponseOutputTextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseOutputTextDelta(global::Inworld.Realtime.UnifiedResponseOutputTextDelta? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputTextDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseOutputTextDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseOutputTextDone?(UnifiedServerEvent @this) => @this.ResponseOutputTextDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputTextDone? value)
        {
            ResponseOutputTextDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseOutputTextDone(global::Inworld.Realtime.UnifiedResponseOutputTextDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta?(UnifiedServerEvent @this) => @this.ResponseOutputAudioTranscriptDelta;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta? value)
        {
            ResponseOutputAudioTranscriptDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseOutputAudioTranscriptDelta(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone?(UnifiedServerEvent @this) => @this.ResponseOutputAudioTranscriptDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone? value)
        {
            ResponseOutputAudioTranscriptDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseOutputAudioTranscriptDone(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputAudioDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseOutputAudioDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseOutputAudioDone?(UnifiedServerEvent @this) => @this.ResponseOutputAudioDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputAudioDone? value)
        {
            ResponseOutputAudioDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseOutputAudioDone(global::Inworld.Realtime.UnifiedResponseOutputAudioDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta?(UnifiedServerEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseFunctionCallArgumentsDelta(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone?(UnifiedServerEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseFunctionCallArgumentsDone(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted?(UnifiedServerEvent @this) => @this.InputAudioBufferSpeechStarted;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted? value)
        {
            InputAudioBufferSpeechStarted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromInputAudioBufferSpeechStarted(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped?(UnifiedServerEvent @this) => @this.InputAudioBufferSpeechStopped;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped? value)
        {
            InputAudioBufferSpeechStopped = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromInputAudioBufferSpeechStopped(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferCommitted value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedInputAudioBufferCommitted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedInputAudioBufferCommitted?(UnifiedServerEvent @this) => @this.InputAudioBufferCommitted;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferCommitted? value)
        {
            InputAudioBufferCommitted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromInputAudioBufferCommitted(global::Inworld.Realtime.UnifiedInputAudioBufferCommitted? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferCleared value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedInputAudioBufferCleared?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedInputAudioBufferCleared?(UnifiedServerEvent @this) => @this.InputAudioBufferCleared;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferCleared? value)
        {
            InputAudioBufferCleared = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromInputAudioBufferCleared(global::Inworld.Realtime.UnifiedInputAudioBufferCleared? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered?(UnifiedServerEvent @this) => @this.InputAudioBufferTimeoutTriggered;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered? value)
        {
            InputAudioBufferTimeoutTriggered = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromInputAudioBufferTimeoutTriggered(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion?(UnifiedServerEvent @this) => @this.InputAudioBufferTurnSuggestion;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion? value)
        {
            InputAudioBufferTurnSuggestion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromInputAudioBufferTurnSuggestion(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked?(UnifiedServerEvent @this) => @this.InputAudioBufferTurnSuggestionRevoked;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked? value)
        {
            InputAudioBufferTurnSuggestionRevoked = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromInputAudioBufferTurnSuggestionRevoked(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedOutputAudioBufferStarted value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedOutputAudioBufferStarted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedOutputAudioBufferStarted?(UnifiedServerEvent @this) => @this.OutputAudioBufferStarted;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedOutputAudioBufferStarted? value)
        {
            OutputAudioBufferStarted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromOutputAudioBufferStarted(global::Inworld.Realtime.UnifiedOutputAudioBufferStarted? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedOutputAudioBufferStopped value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedOutputAudioBufferStopped?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedOutputAudioBufferStopped?(UnifiedServerEvent @this) => @this.OutputAudioBufferStopped;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedOutputAudioBufferStopped? value)
        {
            OutputAudioBufferStopped = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromOutputAudioBufferStopped(global::Inworld.Realtime.UnifiedOutputAudioBufferStopped? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedOutputAudioBufferCleared value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedOutputAudioBufferCleared?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedOutputAudioBufferCleared?(UnifiedServerEvent @this) => @this.OutputAudioBufferCleared;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedOutputAudioBufferCleared? value)
        {
            OutputAudioBufferCleared = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromOutputAudioBufferCleared(global::Inworld.Realtime.UnifiedOutputAudioBufferCleared? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta?(UnifiedServerEvent @this) => @this.ResponseBackchannelAudioDelta;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta? value)
        {
            ResponseBackchannelAudioDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseBackchannelAudioDelta(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone?(UnifiedServerEvent @this) => @this.ResponseBackchannelAudioDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone? value)
        {
            ResponseBackchannelAudioDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseBackchannelAudioDone(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseBackchannelSkipped value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseBackchannelSkipped?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseBackchannelSkipped?(UnifiedServerEvent @this) => @this.ResponseBackchannelSkipped;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseBackchannelSkipped? value)
        {
            ResponseBackchannelSkipped = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseBackchannelSkipped(global::Inworld.Realtime.UnifiedResponseBackchannelSkipped? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedRateLimitsUpdated value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedRateLimitsUpdated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedRateLimitsUpdated?(UnifiedServerEvent @this) => @this.RateLimitsUpdated;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedRateLimitsUpdated? value)
        {
            RateLimitsUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromRateLimitsUpdated(global::Inworld.Realtime.UnifiedRateLimitsUpdated? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputAudioDelta value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseOutputAudioDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseOutputAudioDelta?(UnifiedServerEvent @this) => @this.ResponseOutputAudioDelta;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseOutputAudioDelta? value)
        {
            ResponseOutputAudioDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseOutputAudioDelta(global::Inworld.Realtime.UnifiedResponseOutputAudioDelta? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseAudioDelta value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseAudioDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseAudioDelta?(UnifiedServerEvent @this) => @this.ResponseAudioDelta;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseAudioDelta? value)
        {
            ResponseAudioDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseAudioDelta(global::Inworld.Realtime.UnifiedResponseAudioDelta? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseAudioDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseAudioDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseAudioDone?(UnifiedServerEvent @this) => @this.ResponseAudioDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseAudioDone? value)
        {
            ResponseAudioDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseAudioDone(global::Inworld.Realtime.UnifiedResponseAudioDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseTextDelta value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseTextDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseTextDelta?(UnifiedServerEvent @this) => @this.ResponseTextDelta;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseTextDelta? value)
        {
            ResponseTextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseTextDelta(global::Inworld.Realtime.UnifiedResponseTextDelta? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseTextDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseTextDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseTextDone?(UnifiedServerEvent @this) => @this.ResponseTextDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseTextDone? value)
        {
            ResponseTextDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseTextDone(global::Inworld.Realtime.UnifiedResponseTextDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta?(UnifiedServerEvent @this) => @this.ResponseAudioTranscriptDelta;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta? value)
        {
            ResponseAudioTranscriptDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseAudioTranscriptDelta(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone value) => new UnifiedServerEvent((global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone?(UnifiedServerEvent @this) => @this.ResponseAudioTranscriptDone;

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone? value)
        {
            ResponseAudioTranscriptDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnifiedServerEvent FromResponseAudioTranscriptDone(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone? value) => new UnifiedServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public UnifiedServerEvent(
            global::Inworld.Realtime.UnifiedServerEventDiscriminatorType? type,
            global::Inworld.Realtime.UnifiedSessionCreated? sessionCreated,
            global::Inworld.Realtime.UnifiedSessionUpdated? sessionUpdated,
            global::Inworld.Realtime.UnifiedError? error,
            global::Inworld.Realtime.UnifiedConversationItemAdded? conversationItemAdded,
            global::Inworld.Realtime.UnifiedConversationItemDone? conversationItemDone,
            global::Inworld.Realtime.UnifiedConversationItemDeleted? conversationItemDeleted,
            global::Inworld.Realtime.UnifiedConversationItemRetrieved? conversationItemRetrieved,
            global::Inworld.Realtime.UnifiedConversationItemTruncated? conversationItemTruncated,
            global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta,
            global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted,
            global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged? responseSpeakAcknowledged,
            global::Inworld.Realtime.UnifiedResponseCreated? responseCreated,
            global::Inworld.Realtime.UnifiedResponseDone? responseDone,
            global::Inworld.Realtime.UnifiedResponseOutputItemAdded? responseOutputItemAdded,
            global::Inworld.Realtime.UnifiedResponseOutputItemDone? responseOutputItemDone,
            global::Inworld.Realtime.UnifiedResponseContentPartAdded? responseContentPartAdded,
            global::Inworld.Realtime.UnifiedResponseContentPartDone? responseContentPartDone,
            global::Inworld.Realtime.UnifiedResponseOutputTextDelta? responseOutputTextDelta,
            global::Inworld.Realtime.UnifiedResponseOutputTextDone? responseOutputTextDone,
            global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta? responseOutputAudioTranscriptDelta,
            global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone? responseOutputAudioTranscriptDone,
            global::Inworld.Realtime.UnifiedResponseOutputAudioDone? responseOutputAudioDone,
            global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta,
            global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone,
            global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted,
            global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped,
            global::Inworld.Realtime.UnifiedInputAudioBufferCommitted? inputAudioBufferCommitted,
            global::Inworld.Realtime.UnifiedInputAudioBufferCleared? inputAudioBufferCleared,
            global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered? inputAudioBufferTimeoutTriggered,
            global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion? inputAudioBufferTurnSuggestion,
            global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked? inputAudioBufferTurnSuggestionRevoked,
            global::Inworld.Realtime.UnifiedOutputAudioBufferStarted? outputAudioBufferStarted,
            global::Inworld.Realtime.UnifiedOutputAudioBufferStopped? outputAudioBufferStopped,
            global::Inworld.Realtime.UnifiedOutputAudioBufferCleared? outputAudioBufferCleared,
            global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta? responseBackchannelAudioDelta,
            global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone? responseBackchannelAudioDone,
            global::Inworld.Realtime.UnifiedResponseBackchannelSkipped? responseBackchannelSkipped,
            global::Inworld.Realtime.UnifiedRateLimitsUpdated? rateLimitsUpdated,
            global::Inworld.Realtime.UnifiedResponseOutputAudioDelta? responseOutputAudioDelta,
            global::Inworld.Realtime.UnifiedResponseAudioDelta? responseAudioDelta,
            global::Inworld.Realtime.UnifiedResponseAudioDone? responseAudioDone,
            global::Inworld.Realtime.UnifiedResponseTextDelta? responseTextDelta,
            global::Inworld.Realtime.UnifiedResponseTextDone? responseTextDone,
            global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta? responseAudioTranscriptDelta,
            global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone? responseAudioTranscriptDone
            )
        {
            Type = type;

            SessionCreated = sessionCreated;
            SessionUpdated = sessionUpdated;
            Error = error;
            ConversationItemAdded = conversationItemAdded;
            ConversationItemDone = conversationItemDone;
            ConversationItemDeleted = conversationItemDeleted;
            ConversationItemRetrieved = conversationItemRetrieved;
            ConversationItemTruncated = conversationItemTruncated;
            ConversationItemInputAudioTranscriptionDelta = conversationItemInputAudioTranscriptionDelta;
            ConversationItemInputAudioTranscriptionCompleted = conversationItemInputAudioTranscriptionCompleted;
            ResponseSpeakAcknowledged = responseSpeakAcknowledged;
            ResponseCreated = responseCreated;
            ResponseDone = responseDone;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputItemDone = responseOutputItemDone;
            ResponseContentPartAdded = responseContentPartAdded;
            ResponseContentPartDone = responseContentPartDone;
            ResponseOutputTextDelta = responseOutputTextDelta;
            ResponseOutputTextDone = responseOutputTextDone;
            ResponseOutputAudioTranscriptDelta = responseOutputAudioTranscriptDelta;
            ResponseOutputAudioTranscriptDone = responseOutputAudioTranscriptDone;
            ResponseOutputAudioDone = responseOutputAudioDone;
            ResponseFunctionCallArgumentsDelta = responseFunctionCallArgumentsDelta;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            InputAudioBufferSpeechStarted = inputAudioBufferSpeechStarted;
            InputAudioBufferSpeechStopped = inputAudioBufferSpeechStopped;
            InputAudioBufferCommitted = inputAudioBufferCommitted;
            InputAudioBufferCleared = inputAudioBufferCleared;
            InputAudioBufferTimeoutTriggered = inputAudioBufferTimeoutTriggered;
            InputAudioBufferTurnSuggestion = inputAudioBufferTurnSuggestion;
            InputAudioBufferTurnSuggestionRevoked = inputAudioBufferTurnSuggestionRevoked;
            OutputAudioBufferStarted = outputAudioBufferStarted;
            OutputAudioBufferStopped = outputAudioBufferStopped;
            OutputAudioBufferCleared = outputAudioBufferCleared;
            ResponseBackchannelAudioDelta = responseBackchannelAudioDelta;
            ResponseBackchannelAudioDone = responseBackchannelAudioDone;
            ResponseBackchannelSkipped = responseBackchannelSkipped;
            RateLimitsUpdated = rateLimitsUpdated;
            ResponseOutputAudioDelta = responseOutputAudioDelta;
            ResponseAudioDelta = responseAudioDelta;
            ResponseAudioDone = responseAudioDone;
            ResponseTextDelta = responseTextDelta;
            ResponseTextDone = responseTextDone;
            ResponseAudioTranscriptDelta = responseAudioTranscriptDelta;
            ResponseAudioTranscriptDone = responseAudioTranscriptDone;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseAudioTranscriptDone as object ??
            ResponseAudioTranscriptDelta as object ??
            ResponseTextDone as object ??
            ResponseTextDelta as object ??
            ResponseAudioDone as object ??
            ResponseAudioDelta as object ??
            ResponseOutputAudioDelta as object ??
            RateLimitsUpdated as object ??
            ResponseBackchannelSkipped as object ??
            ResponseBackchannelAudioDone as object ??
            ResponseBackchannelAudioDelta as object ??
            OutputAudioBufferCleared as object ??
            OutputAudioBufferStopped as object ??
            OutputAudioBufferStarted as object ??
            InputAudioBufferTurnSuggestionRevoked as object ??
            InputAudioBufferTurnSuggestion as object ??
            InputAudioBufferTimeoutTriggered as object ??
            InputAudioBufferCleared as object ??
            InputAudioBufferCommitted as object ??
            InputAudioBufferSpeechStopped as object ??
            InputAudioBufferSpeechStarted as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDelta as object ??
            ResponseOutputAudioDone as object ??
            ResponseOutputAudioTranscriptDone as object ??
            ResponseOutputAudioTranscriptDelta as object ??
            ResponseOutputTextDone as object ??
            ResponseOutputTextDelta as object ??
            ResponseContentPartDone as object ??
            ResponseContentPartAdded as object ??
            ResponseOutputItemDone as object ??
            ResponseOutputItemAdded as object ??
            ResponseDone as object ??
            ResponseCreated as object ??
            ResponseSpeakAcknowledged as object ??
            ConversationItemInputAudioTranscriptionCompleted as object ??
            ConversationItemInputAudioTranscriptionDelta as object ??
            ConversationItemTruncated as object ??
            ConversationItemRetrieved as object ??
            ConversationItemDeleted as object ??
            ConversationItemDone as object ??
            ConversationItemAdded as object ??
            Error as object ??
            SessionUpdated as object ??
            SessionCreated as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SessionCreated?.ToString() ??
            SessionUpdated?.ToString() ??
            Error?.ToString() ??
            ConversationItemAdded?.ToString() ??
            ConversationItemDone?.ToString() ??
            ConversationItemDeleted?.ToString() ??
            ConversationItemRetrieved?.ToString() ??
            ConversationItemTruncated?.ToString() ??
            ConversationItemInputAudioTranscriptionDelta?.ToString() ??
            ConversationItemInputAudioTranscriptionCompleted?.ToString() ??
            ResponseSpeakAcknowledged?.ToString() ??
            ResponseCreated?.ToString() ??
            ResponseDone?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputItemDone?.ToString() ??
            ResponseContentPartAdded?.ToString() ??
            ResponseContentPartDone?.ToString() ??
            ResponseOutputTextDelta?.ToString() ??
            ResponseOutputTextDone?.ToString() ??
            ResponseOutputAudioTranscriptDelta?.ToString() ??
            ResponseOutputAudioTranscriptDone?.ToString() ??
            ResponseOutputAudioDone?.ToString() ??
            ResponseFunctionCallArgumentsDelta?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            InputAudioBufferSpeechStarted?.ToString() ??
            InputAudioBufferSpeechStopped?.ToString() ??
            InputAudioBufferCommitted?.ToString() ??
            InputAudioBufferCleared?.ToString() ??
            InputAudioBufferTimeoutTriggered?.ToString() ??
            InputAudioBufferTurnSuggestion?.ToString() ??
            InputAudioBufferTurnSuggestionRevoked?.ToString() ??
            OutputAudioBufferStarted?.ToString() ??
            OutputAudioBufferStopped?.ToString() ??
            OutputAudioBufferCleared?.ToString() ??
            ResponseBackchannelAudioDelta?.ToString() ??
            ResponseBackchannelAudioDone?.ToString() ??
            ResponseBackchannelSkipped?.ToString() ??
            RateLimitsUpdated?.ToString() ??
            ResponseOutputAudioDelta?.ToString() ??
            ResponseAudioDelta?.ToString() ??
            ResponseAudioDone?.ToString() ??
            ResponseTextDelta?.ToString() ??
            ResponseTextDone?.ToString() ??
            ResponseAudioTranscriptDelta?.ToString() ??
            ResponseAudioTranscriptDone?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone || !IsSessionCreated && !IsSessionUpdated && !IsError && !IsConversationItemAdded && !IsConversationItemDone && !IsConversationItemDeleted && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionCompleted && !IsResponseSpeakAcknowledged && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferTimeoutTriggered && !IsInputAudioBufferTurnSuggestion && !IsInputAudioBufferTurnSuggestionRevoked && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsOutputAudioBufferCleared && !IsResponseBackchannelAudioDelta && !IsResponseBackchannelAudioDone && !IsResponseBackchannelSkipped && !IsRateLimitsUpdated && !IsResponseOutputAudioDelta && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && IsResponseAudioTranscriptDone;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Inworld.Realtime.UnifiedSessionCreated, TResult>? sessionCreated = null,
            global::System.Func<global::Inworld.Realtime.UnifiedSessionUpdated, TResult>? sessionUpdated = null,
            global::System.Func<global::Inworld.Realtime.UnifiedError, TResult>? error = null,
            global::System.Func<global::Inworld.Realtime.UnifiedConversationItemAdded, TResult>? conversationItemAdded = null,
            global::System.Func<global::Inworld.Realtime.UnifiedConversationItemDone, TResult>? conversationItemDone = null,
            global::System.Func<global::Inworld.Realtime.UnifiedConversationItemDeleted, TResult>? conversationItemDeleted = null,
            global::System.Func<global::Inworld.Realtime.UnifiedConversationItemRetrieved, TResult>? conversationItemRetrieved = null,
            global::System.Func<global::Inworld.Realtime.UnifiedConversationItemTruncated, TResult>? conversationItemTruncated = null,
            global::System.Func<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta, TResult>? conversationItemInputAudioTranscriptionDelta = null,
            global::System.Func<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted, TResult>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged, TResult>? responseSpeakAcknowledged = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseCreated, TResult>? responseCreated = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseDone, TResult>? responseDone = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseOutputItemAdded, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseOutputItemDone, TResult>? responseOutputItemDone = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseContentPartAdded, TResult>? responseContentPartAdded = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseContentPartDone, TResult>? responseContentPartDone = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseOutputTextDelta, TResult>? responseOutputTextDelta = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseOutputTextDone, TResult>? responseOutputTextDone = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta, TResult>? responseOutputAudioTranscriptDelta = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone, TResult>? responseOutputAudioTranscriptDone = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseOutputAudioDone, TResult>? responseOutputAudioDone = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted, TResult>? inputAudioBufferSpeechStarted = null,
            global::System.Func<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped, TResult>? inputAudioBufferSpeechStopped = null,
            global::System.Func<global::Inworld.Realtime.UnifiedInputAudioBufferCommitted, TResult>? inputAudioBufferCommitted = null,
            global::System.Func<global::Inworld.Realtime.UnifiedInputAudioBufferCleared, TResult>? inputAudioBufferCleared = null,
            global::System.Func<global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered, TResult>? inputAudioBufferTimeoutTriggered = null,
            global::System.Func<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion, TResult>? inputAudioBufferTurnSuggestion = null,
            global::System.Func<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked, TResult>? inputAudioBufferTurnSuggestionRevoked = null,
            global::System.Func<global::Inworld.Realtime.UnifiedOutputAudioBufferStarted, TResult>? outputAudioBufferStarted = null,
            global::System.Func<global::Inworld.Realtime.UnifiedOutputAudioBufferStopped, TResult>? outputAudioBufferStopped = null,
            global::System.Func<global::Inworld.Realtime.UnifiedOutputAudioBufferCleared, TResult>? outputAudioBufferCleared = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta, TResult>? responseBackchannelAudioDelta = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone, TResult>? responseBackchannelAudioDone = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseBackchannelSkipped, TResult>? responseBackchannelSkipped = null,
            global::System.Func<global::Inworld.Realtime.UnifiedRateLimitsUpdated, TResult>? rateLimitsUpdated = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseOutputAudioDelta, TResult>? responseOutputAudioDelta = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseAudioDelta, TResult>? responseAudioDelta = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseAudioDone, TResult>? responseAudioDone = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseTextDelta, TResult>? responseTextDelta = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseTextDone, TResult>? responseTextDone = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta, TResult>? responseAudioTranscriptDelta = null,
            global::System.Func<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone, TResult>? responseAudioTranscriptDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionCreated is { } __value0 && sessionCreated != null)
            {
                return sessionCreated(__value0);
            }
            else if (SessionUpdated is { } __value1 && sessionUpdated != null)
            {
                return sessionUpdated(__value1);
            }
            else if (Error is { } __value2 && error != null)
            {
                return error(__value2);
            }
            else if (ConversationItemAdded is { } __value3 && conversationItemAdded != null)
            {
                return conversationItemAdded(__value3);
            }
            else if (ConversationItemDone is { } __value4 && conversationItemDone != null)
            {
                return conversationItemDone(__value4);
            }
            else if (ConversationItemDeleted is { } __value5 && conversationItemDeleted != null)
            {
                return conversationItemDeleted(__value5);
            }
            else if (ConversationItemRetrieved is { } __value6 && conversationItemRetrieved != null)
            {
                return conversationItemRetrieved(__value6);
            }
            else if (ConversationItemTruncated is { } __value7 && conversationItemTruncated != null)
            {
                return conversationItemTruncated(__value7);
            }
            else if (ConversationItemInputAudioTranscriptionDelta is { } __value8 && conversationItemInputAudioTranscriptionDelta != null)
            {
                return conversationItemInputAudioTranscriptionDelta(__value8);
            }
            else if (ConversationItemInputAudioTranscriptionCompleted is { } __value9 && conversationItemInputAudioTranscriptionCompleted != null)
            {
                return conversationItemInputAudioTranscriptionCompleted(__value9);
            }
            else if (ResponseSpeakAcknowledged is { } __value10 && responseSpeakAcknowledged != null)
            {
                return responseSpeakAcknowledged(__value10);
            }
            else if (ResponseCreated is { } __value11 && responseCreated != null)
            {
                return responseCreated(__value11);
            }
            else if (ResponseDone is { } __value12 && responseDone != null)
            {
                return responseDone(__value12);
            }
            else if (ResponseOutputItemAdded is { } __value13 && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(__value13);
            }
            else if (ResponseOutputItemDone is { } __value14 && responseOutputItemDone != null)
            {
                return responseOutputItemDone(__value14);
            }
            else if (ResponseContentPartAdded is { } __value15 && responseContentPartAdded != null)
            {
                return responseContentPartAdded(__value15);
            }
            else if (ResponseContentPartDone is { } __value16 && responseContentPartDone != null)
            {
                return responseContentPartDone(__value16);
            }
            else if (ResponseOutputTextDelta is { } __value17 && responseOutputTextDelta != null)
            {
                return responseOutputTextDelta(__value17);
            }
            else if (ResponseOutputTextDone is { } __value18 && responseOutputTextDone != null)
            {
                return responseOutputTextDone(__value18);
            }
            else if (ResponseOutputAudioTranscriptDelta is { } __value19 && responseOutputAudioTranscriptDelta != null)
            {
                return responseOutputAudioTranscriptDelta(__value19);
            }
            else if (ResponseOutputAudioTranscriptDone is { } __value20 && responseOutputAudioTranscriptDone != null)
            {
                return responseOutputAudioTranscriptDone(__value20);
            }
            else if (ResponseOutputAudioDone is { } __value21 && responseOutputAudioDone != null)
            {
                return responseOutputAudioDone(__value21);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value22 && responseFunctionCallArgumentsDelta != null)
            {
                return responseFunctionCallArgumentsDelta(__value22);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value23 && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(__value23);
            }
            else if (InputAudioBufferSpeechStarted is { } __value24 && inputAudioBufferSpeechStarted != null)
            {
                return inputAudioBufferSpeechStarted(__value24);
            }
            else if (InputAudioBufferSpeechStopped is { } __value25 && inputAudioBufferSpeechStopped != null)
            {
                return inputAudioBufferSpeechStopped(__value25);
            }
            else if (InputAudioBufferCommitted is { } __value26 && inputAudioBufferCommitted != null)
            {
                return inputAudioBufferCommitted(__value26);
            }
            else if (InputAudioBufferCleared is { } __value27 && inputAudioBufferCleared != null)
            {
                return inputAudioBufferCleared(__value27);
            }
            else if (InputAudioBufferTimeoutTriggered is { } __value28 && inputAudioBufferTimeoutTriggered != null)
            {
                return inputAudioBufferTimeoutTriggered(__value28);
            }
            else if (InputAudioBufferTurnSuggestion is { } __value29 && inputAudioBufferTurnSuggestion != null)
            {
                return inputAudioBufferTurnSuggestion(__value29);
            }
            else if (InputAudioBufferTurnSuggestionRevoked is { } __value30 && inputAudioBufferTurnSuggestionRevoked != null)
            {
                return inputAudioBufferTurnSuggestionRevoked(__value30);
            }
            else if (OutputAudioBufferStarted is { } __value31 && outputAudioBufferStarted != null)
            {
                return outputAudioBufferStarted(__value31);
            }
            else if (OutputAudioBufferStopped is { } __value32 && outputAudioBufferStopped != null)
            {
                return outputAudioBufferStopped(__value32);
            }
            else if (OutputAudioBufferCleared is { } __value33 && outputAudioBufferCleared != null)
            {
                return outputAudioBufferCleared(__value33);
            }
            else if (ResponseBackchannelAudioDelta is { } __value34 && responseBackchannelAudioDelta != null)
            {
                return responseBackchannelAudioDelta(__value34);
            }
            else if (ResponseBackchannelAudioDone is { } __value35 && responseBackchannelAudioDone != null)
            {
                return responseBackchannelAudioDone(__value35);
            }
            else if (ResponseBackchannelSkipped is { } __value36 && responseBackchannelSkipped != null)
            {
                return responseBackchannelSkipped(__value36);
            }
            else if (RateLimitsUpdated is { } __value37 && rateLimitsUpdated != null)
            {
                return rateLimitsUpdated(__value37);
            }
            else if (ResponseOutputAudioDelta is { } __value38 && responseOutputAudioDelta != null)
            {
                return responseOutputAudioDelta(__value38);
            }
            else if (ResponseAudioDelta is { } __value39 && responseAudioDelta != null)
            {
                return responseAudioDelta(__value39);
            }
            else if (ResponseAudioDone is { } __value40 && responseAudioDone != null)
            {
                return responseAudioDone(__value40);
            }
            else if (ResponseTextDelta is { } __value41 && responseTextDelta != null)
            {
                return responseTextDelta(__value41);
            }
            else if (ResponseTextDone is { } __value42 && responseTextDone != null)
            {
                return responseTextDone(__value42);
            }
            else if (ResponseAudioTranscriptDelta is { } __value43 && responseAudioTranscriptDelta != null)
            {
                return responseAudioTranscriptDelta(__value43);
            }
            else if (ResponseAudioTranscriptDone is { } __value44 && responseAudioTranscriptDone != null)
            {
                return responseAudioTranscriptDone(__value44);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Inworld.Realtime.UnifiedSessionCreated>? sessionCreated = null,

            global::System.Action<global::Inworld.Realtime.UnifiedSessionUpdated>? sessionUpdated = null,

            global::System.Action<global::Inworld.Realtime.UnifiedError>? error = null,

            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemAdded>? conversationItemAdded = null,

            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemDone>? conversationItemDone = null,

            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemDeleted>? conversationItemDeleted = null,

            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemRetrieved>? conversationItemRetrieved = null,

            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemTruncated>? conversationItemTruncated = null,

            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta>? conversationItemInputAudioTranscriptionDelta = null,

            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted>? conversationItemInputAudioTranscriptionCompleted = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged>? responseSpeakAcknowledged = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseCreated>? responseCreated = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseDone>? responseDone = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputItemAdded>? responseOutputItemAdded = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputItemDone>? responseOutputItemDone = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseContentPartAdded>? responseContentPartAdded = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseContentPartDone>? responseContentPartDone = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputTextDelta>? responseOutputTextDelta = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputTextDone>? responseOutputTextDone = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta>? responseOutputAudioTranscriptDelta = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone>? responseOutputAudioTranscriptDone = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputAudioDone>? responseOutputAudioDone = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta>? responseFunctionCallArgumentsDelta = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone>? responseFunctionCallArgumentsDone = null,

            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted>? inputAudioBufferSpeechStarted = null,

            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped>? inputAudioBufferSpeechStopped = null,

            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferCommitted>? inputAudioBufferCommitted = null,

            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferCleared>? inputAudioBufferCleared = null,

            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered>? inputAudioBufferTimeoutTriggered = null,

            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion>? inputAudioBufferTurnSuggestion = null,

            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked>? inputAudioBufferTurnSuggestionRevoked = null,

            global::System.Action<global::Inworld.Realtime.UnifiedOutputAudioBufferStarted>? outputAudioBufferStarted = null,

            global::System.Action<global::Inworld.Realtime.UnifiedOutputAudioBufferStopped>? outputAudioBufferStopped = null,

            global::System.Action<global::Inworld.Realtime.UnifiedOutputAudioBufferCleared>? outputAudioBufferCleared = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta>? responseBackchannelAudioDelta = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone>? responseBackchannelAudioDone = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseBackchannelSkipped>? responseBackchannelSkipped = null,

            global::System.Action<global::Inworld.Realtime.UnifiedRateLimitsUpdated>? rateLimitsUpdated = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputAudioDelta>? responseOutputAudioDelta = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseAudioDelta>? responseAudioDelta = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseAudioDone>? responseAudioDone = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseTextDelta>? responseTextDelta = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseTextDone>? responseTextDone = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta>? responseAudioTranscriptDelta = null,

            global::System.Action<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone>? responseAudioTranscriptDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionCreated is { } __value0)
            {
                sessionCreated?.Invoke(__value0);
            }
            else if (SessionUpdated is { } __value1)
            {
                sessionUpdated?.Invoke(__value1);
            }
            else if (Error is { } __value2)
            {
                error?.Invoke(__value2);
            }
            else if (ConversationItemAdded is { } __value3)
            {
                conversationItemAdded?.Invoke(__value3);
            }
            else if (ConversationItemDone is { } __value4)
            {
                conversationItemDone?.Invoke(__value4);
            }
            else if (ConversationItemDeleted is { } __value5)
            {
                conversationItemDeleted?.Invoke(__value5);
            }
            else if (ConversationItemRetrieved is { } __value6)
            {
                conversationItemRetrieved?.Invoke(__value6);
            }
            else if (ConversationItemTruncated is { } __value7)
            {
                conversationItemTruncated?.Invoke(__value7);
            }
            else if (ConversationItemInputAudioTranscriptionDelta is { } __value8)
            {
                conversationItemInputAudioTranscriptionDelta?.Invoke(__value8);
            }
            else if (ConversationItemInputAudioTranscriptionCompleted is { } __value9)
            {
                conversationItemInputAudioTranscriptionCompleted?.Invoke(__value9);
            }
            else if (ResponseSpeakAcknowledged is { } __value10)
            {
                responseSpeakAcknowledged?.Invoke(__value10);
            }
            else if (ResponseCreated is { } __value11)
            {
                responseCreated?.Invoke(__value11);
            }
            else if (ResponseDone is { } __value12)
            {
                responseDone?.Invoke(__value12);
            }
            else if (ResponseOutputItemAdded is { } __value13)
            {
                responseOutputItemAdded?.Invoke(__value13);
            }
            else if (ResponseOutputItemDone is { } __value14)
            {
                responseOutputItemDone?.Invoke(__value14);
            }
            else if (ResponseContentPartAdded is { } __value15)
            {
                responseContentPartAdded?.Invoke(__value15);
            }
            else if (ResponseContentPartDone is { } __value16)
            {
                responseContentPartDone?.Invoke(__value16);
            }
            else if (ResponseOutputTextDelta is { } __value17)
            {
                responseOutputTextDelta?.Invoke(__value17);
            }
            else if (ResponseOutputTextDone is { } __value18)
            {
                responseOutputTextDone?.Invoke(__value18);
            }
            else if (ResponseOutputAudioTranscriptDelta is { } __value19)
            {
                responseOutputAudioTranscriptDelta?.Invoke(__value19);
            }
            else if (ResponseOutputAudioTranscriptDone is { } __value20)
            {
                responseOutputAudioTranscriptDone?.Invoke(__value20);
            }
            else if (ResponseOutputAudioDone is { } __value21)
            {
                responseOutputAudioDone?.Invoke(__value21);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value22)
            {
                responseFunctionCallArgumentsDelta?.Invoke(__value22);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value23)
            {
                responseFunctionCallArgumentsDone?.Invoke(__value23);
            }
            else if (InputAudioBufferSpeechStarted is { } __value24)
            {
                inputAudioBufferSpeechStarted?.Invoke(__value24);
            }
            else if (InputAudioBufferSpeechStopped is { } __value25)
            {
                inputAudioBufferSpeechStopped?.Invoke(__value25);
            }
            else if (InputAudioBufferCommitted is { } __value26)
            {
                inputAudioBufferCommitted?.Invoke(__value26);
            }
            else if (InputAudioBufferCleared is { } __value27)
            {
                inputAudioBufferCleared?.Invoke(__value27);
            }
            else if (InputAudioBufferTimeoutTriggered is { } __value28)
            {
                inputAudioBufferTimeoutTriggered?.Invoke(__value28);
            }
            else if (InputAudioBufferTurnSuggestion is { } __value29)
            {
                inputAudioBufferTurnSuggestion?.Invoke(__value29);
            }
            else if (InputAudioBufferTurnSuggestionRevoked is { } __value30)
            {
                inputAudioBufferTurnSuggestionRevoked?.Invoke(__value30);
            }
            else if (OutputAudioBufferStarted is { } __value31)
            {
                outputAudioBufferStarted?.Invoke(__value31);
            }
            else if (OutputAudioBufferStopped is { } __value32)
            {
                outputAudioBufferStopped?.Invoke(__value32);
            }
            else if (OutputAudioBufferCleared is { } __value33)
            {
                outputAudioBufferCleared?.Invoke(__value33);
            }
            else if (ResponseBackchannelAudioDelta is { } __value34)
            {
                responseBackchannelAudioDelta?.Invoke(__value34);
            }
            else if (ResponseBackchannelAudioDone is { } __value35)
            {
                responseBackchannelAudioDone?.Invoke(__value35);
            }
            else if (ResponseBackchannelSkipped is { } __value36)
            {
                responseBackchannelSkipped?.Invoke(__value36);
            }
            else if (RateLimitsUpdated is { } __value37)
            {
                rateLimitsUpdated?.Invoke(__value37);
            }
            else if (ResponseOutputAudioDelta is { } __value38)
            {
                responseOutputAudioDelta?.Invoke(__value38);
            }
            else if (ResponseAudioDelta is { } __value39)
            {
                responseAudioDelta?.Invoke(__value39);
            }
            else if (ResponseAudioDone is { } __value40)
            {
                responseAudioDone?.Invoke(__value40);
            }
            else if (ResponseTextDelta is { } __value41)
            {
                responseTextDelta?.Invoke(__value41);
            }
            else if (ResponseTextDone is { } __value42)
            {
                responseTextDone?.Invoke(__value42);
            }
            else if (ResponseAudioTranscriptDelta is { } __value43)
            {
                responseAudioTranscriptDelta?.Invoke(__value43);
            }
            else if (ResponseAudioTranscriptDone is { } __value44)
            {
                responseAudioTranscriptDone?.Invoke(__value44);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Inworld.Realtime.UnifiedSessionCreated>? sessionCreated = null,
            global::System.Action<global::Inworld.Realtime.UnifiedSessionUpdated>? sessionUpdated = null,
            global::System.Action<global::Inworld.Realtime.UnifiedError>? error = null,
            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemAdded>? conversationItemAdded = null,
            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemDone>? conversationItemDone = null,
            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemDeleted>? conversationItemDeleted = null,
            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemRetrieved>? conversationItemRetrieved = null,
            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemTruncated>? conversationItemTruncated = null,
            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta>? conversationItemInputAudioTranscriptionDelta = null,
            global::System.Action<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged>? responseSpeakAcknowledged = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseCreated>? responseCreated = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseDone>? responseDone = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputItemAdded>? responseOutputItemAdded = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputItemDone>? responseOutputItemDone = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseContentPartAdded>? responseContentPartAdded = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseContentPartDone>? responseContentPartDone = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputTextDelta>? responseOutputTextDelta = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputTextDone>? responseOutputTextDone = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta>? responseOutputAudioTranscriptDelta = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone>? responseOutputAudioTranscriptDone = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputAudioDone>? responseOutputAudioDone = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted>? inputAudioBufferSpeechStarted = null,
            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped>? inputAudioBufferSpeechStopped = null,
            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferCommitted>? inputAudioBufferCommitted = null,
            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferCleared>? inputAudioBufferCleared = null,
            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered>? inputAudioBufferTimeoutTriggered = null,
            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion>? inputAudioBufferTurnSuggestion = null,
            global::System.Action<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked>? inputAudioBufferTurnSuggestionRevoked = null,
            global::System.Action<global::Inworld.Realtime.UnifiedOutputAudioBufferStarted>? outputAudioBufferStarted = null,
            global::System.Action<global::Inworld.Realtime.UnifiedOutputAudioBufferStopped>? outputAudioBufferStopped = null,
            global::System.Action<global::Inworld.Realtime.UnifiedOutputAudioBufferCleared>? outputAudioBufferCleared = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta>? responseBackchannelAudioDelta = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone>? responseBackchannelAudioDone = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseBackchannelSkipped>? responseBackchannelSkipped = null,
            global::System.Action<global::Inworld.Realtime.UnifiedRateLimitsUpdated>? rateLimitsUpdated = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseOutputAudioDelta>? responseOutputAudioDelta = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseAudioDelta>? responseAudioDelta = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseAudioDone>? responseAudioDone = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseTextDelta>? responseTextDelta = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseTextDone>? responseTextDone = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta>? responseAudioTranscriptDelta = null,
            global::System.Action<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone>? responseAudioTranscriptDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionCreated is { } __value0)
            {
                sessionCreated?.Invoke(__value0);
            }
            else if (SessionUpdated is { } __value1)
            {
                sessionUpdated?.Invoke(__value1);
            }
            else if (Error is { } __value2)
            {
                error?.Invoke(__value2);
            }
            else if (ConversationItemAdded is { } __value3)
            {
                conversationItemAdded?.Invoke(__value3);
            }
            else if (ConversationItemDone is { } __value4)
            {
                conversationItemDone?.Invoke(__value4);
            }
            else if (ConversationItemDeleted is { } __value5)
            {
                conversationItemDeleted?.Invoke(__value5);
            }
            else if (ConversationItemRetrieved is { } __value6)
            {
                conversationItemRetrieved?.Invoke(__value6);
            }
            else if (ConversationItemTruncated is { } __value7)
            {
                conversationItemTruncated?.Invoke(__value7);
            }
            else if (ConversationItemInputAudioTranscriptionDelta is { } __value8)
            {
                conversationItemInputAudioTranscriptionDelta?.Invoke(__value8);
            }
            else if (ConversationItemInputAudioTranscriptionCompleted is { } __value9)
            {
                conversationItemInputAudioTranscriptionCompleted?.Invoke(__value9);
            }
            else if (ResponseSpeakAcknowledged is { } __value10)
            {
                responseSpeakAcknowledged?.Invoke(__value10);
            }
            else if (ResponseCreated is { } __value11)
            {
                responseCreated?.Invoke(__value11);
            }
            else if (ResponseDone is { } __value12)
            {
                responseDone?.Invoke(__value12);
            }
            else if (ResponseOutputItemAdded is { } __value13)
            {
                responseOutputItemAdded?.Invoke(__value13);
            }
            else if (ResponseOutputItemDone is { } __value14)
            {
                responseOutputItemDone?.Invoke(__value14);
            }
            else if (ResponseContentPartAdded is { } __value15)
            {
                responseContentPartAdded?.Invoke(__value15);
            }
            else if (ResponseContentPartDone is { } __value16)
            {
                responseContentPartDone?.Invoke(__value16);
            }
            else if (ResponseOutputTextDelta is { } __value17)
            {
                responseOutputTextDelta?.Invoke(__value17);
            }
            else if (ResponseOutputTextDone is { } __value18)
            {
                responseOutputTextDone?.Invoke(__value18);
            }
            else if (ResponseOutputAudioTranscriptDelta is { } __value19)
            {
                responseOutputAudioTranscriptDelta?.Invoke(__value19);
            }
            else if (ResponseOutputAudioTranscriptDone is { } __value20)
            {
                responseOutputAudioTranscriptDone?.Invoke(__value20);
            }
            else if (ResponseOutputAudioDone is { } __value21)
            {
                responseOutputAudioDone?.Invoke(__value21);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value22)
            {
                responseFunctionCallArgumentsDelta?.Invoke(__value22);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value23)
            {
                responseFunctionCallArgumentsDone?.Invoke(__value23);
            }
            else if (InputAudioBufferSpeechStarted is { } __value24)
            {
                inputAudioBufferSpeechStarted?.Invoke(__value24);
            }
            else if (InputAudioBufferSpeechStopped is { } __value25)
            {
                inputAudioBufferSpeechStopped?.Invoke(__value25);
            }
            else if (InputAudioBufferCommitted is { } __value26)
            {
                inputAudioBufferCommitted?.Invoke(__value26);
            }
            else if (InputAudioBufferCleared is { } __value27)
            {
                inputAudioBufferCleared?.Invoke(__value27);
            }
            else if (InputAudioBufferTimeoutTriggered is { } __value28)
            {
                inputAudioBufferTimeoutTriggered?.Invoke(__value28);
            }
            else if (InputAudioBufferTurnSuggestion is { } __value29)
            {
                inputAudioBufferTurnSuggestion?.Invoke(__value29);
            }
            else if (InputAudioBufferTurnSuggestionRevoked is { } __value30)
            {
                inputAudioBufferTurnSuggestionRevoked?.Invoke(__value30);
            }
            else if (OutputAudioBufferStarted is { } __value31)
            {
                outputAudioBufferStarted?.Invoke(__value31);
            }
            else if (OutputAudioBufferStopped is { } __value32)
            {
                outputAudioBufferStopped?.Invoke(__value32);
            }
            else if (OutputAudioBufferCleared is { } __value33)
            {
                outputAudioBufferCleared?.Invoke(__value33);
            }
            else if (ResponseBackchannelAudioDelta is { } __value34)
            {
                responseBackchannelAudioDelta?.Invoke(__value34);
            }
            else if (ResponseBackchannelAudioDone is { } __value35)
            {
                responseBackchannelAudioDone?.Invoke(__value35);
            }
            else if (ResponseBackchannelSkipped is { } __value36)
            {
                responseBackchannelSkipped?.Invoke(__value36);
            }
            else if (RateLimitsUpdated is { } __value37)
            {
                rateLimitsUpdated?.Invoke(__value37);
            }
            else if (ResponseOutputAudioDelta is { } __value38)
            {
                responseOutputAudioDelta?.Invoke(__value38);
            }
            else if (ResponseAudioDelta is { } __value39)
            {
                responseAudioDelta?.Invoke(__value39);
            }
            else if (ResponseAudioDone is { } __value40)
            {
                responseAudioDone?.Invoke(__value40);
            }
            else if (ResponseTextDelta is { } __value41)
            {
                responseTextDelta?.Invoke(__value41);
            }
            else if (ResponseTextDone is { } __value42)
            {
                responseTextDone?.Invoke(__value42);
            }
            else if (ResponseAudioTranscriptDelta is { } __value43)
            {
                responseAudioTranscriptDelta?.Invoke(__value43);
            }
            else if (ResponseAudioTranscriptDone is { } __value44)
            {
                responseAudioTranscriptDone?.Invoke(__value44);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionCreated,
                typeof(global::Inworld.Realtime.UnifiedSessionCreated),
                SessionUpdated,
                typeof(global::Inworld.Realtime.UnifiedSessionUpdated),
                Error,
                typeof(global::Inworld.Realtime.UnifiedError),
                ConversationItemAdded,
                typeof(global::Inworld.Realtime.UnifiedConversationItemAdded),
                ConversationItemDone,
                typeof(global::Inworld.Realtime.UnifiedConversationItemDone),
                ConversationItemDeleted,
                typeof(global::Inworld.Realtime.UnifiedConversationItemDeleted),
                ConversationItemRetrieved,
                typeof(global::Inworld.Realtime.UnifiedConversationItemRetrieved),
                ConversationItemTruncated,
                typeof(global::Inworld.Realtime.UnifiedConversationItemTruncated),
                ConversationItemInputAudioTranscriptionDelta,
                typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta),
                ConversationItemInputAudioTranscriptionCompleted,
                typeof(global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted),
                ResponseSpeakAcknowledged,
                typeof(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged),
                ResponseCreated,
                typeof(global::Inworld.Realtime.UnifiedResponseCreated),
                ResponseDone,
                typeof(global::Inworld.Realtime.UnifiedResponseDone),
                ResponseOutputItemAdded,
                typeof(global::Inworld.Realtime.UnifiedResponseOutputItemAdded),
                ResponseOutputItemDone,
                typeof(global::Inworld.Realtime.UnifiedResponseOutputItemDone),
                ResponseContentPartAdded,
                typeof(global::Inworld.Realtime.UnifiedResponseContentPartAdded),
                ResponseContentPartDone,
                typeof(global::Inworld.Realtime.UnifiedResponseContentPartDone),
                ResponseOutputTextDelta,
                typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDelta),
                ResponseOutputTextDone,
                typeof(global::Inworld.Realtime.UnifiedResponseOutputTextDone),
                ResponseOutputAudioTranscriptDelta,
                typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta),
                ResponseOutputAudioTranscriptDone,
                typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone),
                ResponseOutputAudioDone,
                typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDone),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta),
                ResponseFunctionCallArgumentsDone,
                typeof(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone),
                InputAudioBufferSpeechStarted,
                typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted),
                InputAudioBufferSpeechStopped,
                typeof(global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped),
                InputAudioBufferCommitted,
                typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCommitted),
                InputAudioBufferCleared,
                typeof(global::Inworld.Realtime.UnifiedInputAudioBufferCleared),
                InputAudioBufferTimeoutTriggered,
                typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered),
                InputAudioBufferTurnSuggestion,
                typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion),
                InputAudioBufferTurnSuggestionRevoked,
                typeof(global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked),
                OutputAudioBufferStarted,
                typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStarted),
                OutputAudioBufferStopped,
                typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferStopped),
                OutputAudioBufferCleared,
                typeof(global::Inworld.Realtime.UnifiedOutputAudioBufferCleared),
                ResponseBackchannelAudioDelta,
                typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta),
                ResponseBackchannelAudioDone,
                typeof(global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone),
                ResponseBackchannelSkipped,
                typeof(global::Inworld.Realtime.UnifiedResponseBackchannelSkipped),
                RateLimitsUpdated,
                typeof(global::Inworld.Realtime.UnifiedRateLimitsUpdated),
                ResponseOutputAudioDelta,
                typeof(global::Inworld.Realtime.UnifiedResponseOutputAudioDelta),
                ResponseAudioDelta,
                typeof(global::Inworld.Realtime.UnifiedResponseAudioDelta),
                ResponseAudioDone,
                typeof(global::Inworld.Realtime.UnifiedResponseAudioDone),
                ResponseTextDelta,
                typeof(global::Inworld.Realtime.UnifiedResponseTextDelta),
                ResponseTextDone,
                typeof(global::Inworld.Realtime.UnifiedResponseTextDone),
                ResponseAudioTranscriptDelta,
                typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta),
                ResponseAudioTranscriptDone,
                typeof(global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(UnifiedServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedSessionCreated?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedSessionUpdated?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedConversationItemAdded?>.Default.Equals(ConversationItemAdded, other.ConversationItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedConversationItemDone?>.Default.Equals(ConversationItemDone, other.ConversationItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedConversationItemDeleted?>.Default.Equals(ConversationItemDeleted, other.ConversationItemDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedConversationItemRetrieved?>.Default.Equals(ConversationItemRetrieved, other.ConversationItemRetrieved) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedConversationItemTruncated?>.Default.Equals(ConversationItemTruncated, other.ConversationItemTruncated) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionDelta?>.Default.Equals(ConversationItemInputAudioTranscriptionDelta, other.ConversationItemInputAudioTranscriptionDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedConversationItemInputAudioTranscriptionCompleted?>.Default.Equals(ConversationItemInputAudioTranscriptionCompleted, other.ConversationItemInputAudioTranscriptionCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseSpeakAcknowledged?>.Default.Equals(ResponseSpeakAcknowledged, other.ResponseSpeakAcknowledged) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseCreated?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseDone?>.Default.Equals(ResponseDone, other.ResponseDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseOutputItemAdded?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseOutputItemDone?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseContentPartAdded?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseContentPartDone?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseOutputTextDelta?>.Default.Equals(ResponseOutputTextDelta, other.ResponseOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseOutputTextDone?>.Default.Equals(ResponseOutputTextDone, other.ResponseOutputTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDelta?>.Default.Equals(ResponseOutputAudioTranscriptDelta, other.ResponseOutputAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseOutputAudioTranscriptDone?>.Default.Equals(ResponseOutputAudioTranscriptDone, other.ResponseOutputAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseOutputAudioDone?>.Default.Equals(ResponseOutputAudioDone, other.ResponseOutputAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDelta?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDone?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStarted?>.Default.Equals(InputAudioBufferSpeechStarted, other.InputAudioBufferSpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedInputAudioBufferSpeechStopped?>.Default.Equals(InputAudioBufferSpeechStopped, other.InputAudioBufferSpeechStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedInputAudioBufferCommitted?>.Default.Equals(InputAudioBufferCommitted, other.InputAudioBufferCommitted) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedInputAudioBufferCleared?>.Default.Equals(InputAudioBufferCleared, other.InputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggered?>.Default.Equals(InputAudioBufferTimeoutTriggered, other.InputAudioBufferTimeoutTriggered) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestion?>.Default.Equals(InputAudioBufferTurnSuggestion, other.InputAudioBufferTurnSuggestion) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedInputAudioBufferTurnSuggestionRevoked?>.Default.Equals(InputAudioBufferTurnSuggestionRevoked, other.InputAudioBufferTurnSuggestionRevoked) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedOutputAudioBufferStarted?>.Default.Equals(OutputAudioBufferStarted, other.OutputAudioBufferStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedOutputAudioBufferStopped?>.Default.Equals(OutputAudioBufferStopped, other.OutputAudioBufferStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedOutputAudioBufferCleared?>.Default.Equals(OutputAudioBufferCleared, other.OutputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDelta?>.Default.Equals(ResponseBackchannelAudioDelta, other.ResponseBackchannelAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseBackchannelAudioDone?>.Default.Equals(ResponseBackchannelAudioDone, other.ResponseBackchannelAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseBackchannelSkipped?>.Default.Equals(ResponseBackchannelSkipped, other.ResponseBackchannelSkipped) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedRateLimitsUpdated?>.Default.Equals(RateLimitsUpdated, other.RateLimitsUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseOutputAudioDelta?>.Default.Equals(ResponseOutputAudioDelta, other.ResponseOutputAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseAudioDelta?>.Default.Equals(ResponseAudioDelta, other.ResponseAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseAudioDone?>.Default.Equals(ResponseAudioDone, other.ResponseAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseTextDelta?>.Default.Equals(ResponseTextDelta, other.ResponseTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseTextDone?>.Default.Equals(ResponseTextDone, other.ResponseTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDelta?>.Default.Equals(ResponseAudioTranscriptDelta, other.ResponseAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.UnifiedResponseAudioTranscriptDone?>.Default.Equals(ResponseAudioTranscriptDone, other.ResponseAudioTranscriptDone)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UnifiedServerEvent obj1, UnifiedServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnifiedServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnifiedServerEvent obj1, UnifiedServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnifiedServerEvent o && Equals(o);
        }
    }
}
