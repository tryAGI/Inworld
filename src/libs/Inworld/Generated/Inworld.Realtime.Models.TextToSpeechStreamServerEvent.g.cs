#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TextToSpeechStreamServerEvent : global::System.IEquatable<TextToSpeechStreamServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.TtsContextCreated? TtsContextCreated { get; init; }
#else
        public global::Inworld.Realtime.TtsContextCreated? TtsContextCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TtsContextCreated))]
#endif
        public bool IsTtsContextCreated => TtsContextCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTtsContextCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.TtsContextCreated? value)
        {
            value = TtsContextCreated;
            return IsTtsContextCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsContextCreated PickTtsContextCreated() => IsTtsContextCreated
            ? TtsContextCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TtsContextCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.TtsAudioChunk? TtsAudioChunk { get; init; }
#else
        public global::Inworld.Realtime.TtsAudioChunk? TtsAudioChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TtsAudioChunk))]
#endif
        public bool IsTtsAudioChunk => TtsAudioChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTtsAudioChunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.TtsAudioChunk? value)
        {
            value = TtsAudioChunk;
            return IsTtsAudioChunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsAudioChunk PickTtsAudioChunk() => IsTtsAudioChunk
            ? TtsAudioChunk!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TtsAudioChunk' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.TtsFlushCompleted? TtsFlushCompleted { get; init; }
#else
        public global::Inworld.Realtime.TtsFlushCompleted? TtsFlushCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TtsFlushCompleted))]
#endif
        public bool IsTtsFlushCompleted => TtsFlushCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTtsFlushCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.TtsFlushCompleted? value)
        {
            value = TtsFlushCompleted;
            return IsTtsFlushCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsFlushCompleted PickTtsFlushCompleted() => IsTtsFlushCompleted
            ? TtsFlushCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TtsFlushCompleted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.TtsContextClosed? TtsContextClosed { get; init; }
#else
        public global::Inworld.Realtime.TtsContextClosed? TtsContextClosed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TtsContextClosed))]
#endif
        public bool IsTtsContextClosed => TtsContextClosed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTtsContextClosed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inworld.Realtime.TtsContextClosed? value)
        {
            value = TtsContextClosed;
            return IsTtsContextClosed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Inworld.Realtime.TtsContextClosed PickTtsContextClosed() => IsTtsContextClosed
            ? TtsContextClosed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TtsContextClosed' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechStreamServerEvent(global::Inworld.Realtime.TtsContextCreated value) => new TextToSpeechStreamServerEvent((global::Inworld.Realtime.TtsContextCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Inworld.Realtime.TtsContextCreated?(TextToSpeechStreamServerEvent @this) => @this.TtsContextCreated;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechStreamServerEvent(global::Inworld.Realtime.TtsContextCreated? value)
        {
            TtsContextCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TextToSpeechStreamServerEvent FromTtsContextCreated(global::Inworld.Realtime.TtsContextCreated? value) => new TextToSpeechStreamServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechStreamServerEvent(global::Inworld.Realtime.TtsAudioChunk value) => new TextToSpeechStreamServerEvent((global::Inworld.Realtime.TtsAudioChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Inworld.Realtime.TtsAudioChunk?(TextToSpeechStreamServerEvent @this) => @this.TtsAudioChunk;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechStreamServerEvent(global::Inworld.Realtime.TtsAudioChunk? value)
        {
            TtsAudioChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TextToSpeechStreamServerEvent FromTtsAudioChunk(global::Inworld.Realtime.TtsAudioChunk? value) => new TextToSpeechStreamServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechStreamServerEvent(global::Inworld.Realtime.TtsFlushCompleted value) => new TextToSpeechStreamServerEvent((global::Inworld.Realtime.TtsFlushCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Inworld.Realtime.TtsFlushCompleted?(TextToSpeechStreamServerEvent @this) => @this.TtsFlushCompleted;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechStreamServerEvent(global::Inworld.Realtime.TtsFlushCompleted? value)
        {
            TtsFlushCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TextToSpeechStreamServerEvent FromTtsFlushCompleted(global::Inworld.Realtime.TtsFlushCompleted? value) => new TextToSpeechStreamServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechStreamServerEvent(global::Inworld.Realtime.TtsContextClosed value) => new TextToSpeechStreamServerEvent((global::Inworld.Realtime.TtsContextClosed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Inworld.Realtime.TtsContextClosed?(TextToSpeechStreamServerEvent @this) => @this.TtsContextClosed;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechStreamServerEvent(global::Inworld.Realtime.TtsContextClosed? value)
        {
            TtsContextClosed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TextToSpeechStreamServerEvent FromTtsContextClosed(global::Inworld.Realtime.TtsContextClosed? value) => new TextToSpeechStreamServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechStreamServerEvent(
            global::Inworld.Realtime.TtsContextCreated? ttsContextCreated,
            global::Inworld.Realtime.TtsAudioChunk? ttsAudioChunk,
            global::Inworld.Realtime.TtsFlushCompleted? ttsFlushCompleted,
            global::Inworld.Realtime.TtsContextClosed? ttsContextClosed
            )
        {
            TtsContextCreated = ttsContextCreated;
            TtsAudioChunk = ttsAudioChunk;
            TtsFlushCompleted = ttsFlushCompleted;
            TtsContextClosed = ttsContextClosed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TtsContextClosed as object ??
            TtsFlushCompleted as object ??
            TtsAudioChunk as object ??
            TtsContextCreated as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TtsContextCreated?.ToString() ??
            TtsAudioChunk?.ToString() ??
            TtsFlushCompleted?.ToString() ??
            TtsContextClosed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTtsContextCreated && !IsTtsAudioChunk && !IsTtsFlushCompleted && !IsTtsContextClosed || !IsTtsContextCreated && IsTtsAudioChunk && !IsTtsFlushCompleted && !IsTtsContextClosed || !IsTtsContextCreated && !IsTtsAudioChunk && IsTtsFlushCompleted && !IsTtsContextClosed || !IsTtsContextCreated && !IsTtsAudioChunk && !IsTtsFlushCompleted && IsTtsContextClosed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Inworld.Realtime.TtsContextCreated, TResult>? ttsContextCreated = null,
            global::System.Func<global::Inworld.Realtime.TtsAudioChunk, TResult>? ttsAudioChunk = null,
            global::System.Func<global::Inworld.Realtime.TtsFlushCompleted, TResult>? ttsFlushCompleted = null,
            global::System.Func<global::Inworld.Realtime.TtsContextClosed, TResult>? ttsContextClosed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTtsContextCreated && ttsContextCreated != null)
            {
                return ttsContextCreated(TtsContextCreated!);
            }
            else if (IsTtsAudioChunk && ttsAudioChunk != null)
            {
                return ttsAudioChunk(TtsAudioChunk!);
            }
            else if (IsTtsFlushCompleted && ttsFlushCompleted != null)
            {
                return ttsFlushCompleted(TtsFlushCompleted!);
            }
            else if (IsTtsContextClosed && ttsContextClosed != null)
            {
                return ttsContextClosed(TtsContextClosed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Inworld.Realtime.TtsContextCreated>? ttsContextCreated = null,

            global::System.Action<global::Inworld.Realtime.TtsAudioChunk>? ttsAudioChunk = null,

            global::System.Action<global::Inworld.Realtime.TtsFlushCompleted>? ttsFlushCompleted = null,

            global::System.Action<global::Inworld.Realtime.TtsContextClosed>? ttsContextClosed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTtsContextCreated)
            {
                ttsContextCreated?.Invoke(TtsContextCreated!);
            }
            else if (IsTtsAudioChunk)
            {
                ttsAudioChunk?.Invoke(TtsAudioChunk!);
            }
            else if (IsTtsFlushCompleted)
            {
                ttsFlushCompleted?.Invoke(TtsFlushCompleted!);
            }
            else if (IsTtsContextClosed)
            {
                ttsContextClosed?.Invoke(TtsContextClosed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Inworld.Realtime.TtsContextCreated>? ttsContextCreated = null,
            global::System.Action<global::Inworld.Realtime.TtsAudioChunk>? ttsAudioChunk = null,
            global::System.Action<global::Inworld.Realtime.TtsFlushCompleted>? ttsFlushCompleted = null,
            global::System.Action<global::Inworld.Realtime.TtsContextClosed>? ttsContextClosed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTtsContextCreated)
            {
                ttsContextCreated?.Invoke(TtsContextCreated!);
            }
            else if (IsTtsAudioChunk)
            {
                ttsAudioChunk?.Invoke(TtsAudioChunk!);
            }
            else if (IsTtsFlushCompleted)
            {
                ttsFlushCompleted?.Invoke(TtsFlushCompleted!);
            }
            else if (IsTtsContextClosed)
            {
                ttsContextClosed?.Invoke(TtsContextClosed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TtsContextCreated,
                typeof(global::Inworld.Realtime.TtsContextCreated),
                TtsAudioChunk,
                typeof(global::Inworld.Realtime.TtsAudioChunk),
                TtsFlushCompleted,
                typeof(global::Inworld.Realtime.TtsFlushCompleted),
                TtsContextClosed,
                typeof(global::Inworld.Realtime.TtsContextClosed),
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
        public bool Equals(TextToSpeechStreamServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.TtsContextCreated?>.Default.Equals(TtsContextCreated, other.TtsContextCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.TtsAudioChunk?>.Default.Equals(TtsAudioChunk, other.TtsAudioChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.TtsFlushCompleted?>.Default.Equals(TtsFlushCompleted, other.TtsFlushCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.TtsContextClosed?>.Default.Equals(TtsContextClosed, other.TtsContextClosed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextToSpeechStreamServerEvent obj1, TextToSpeechStreamServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextToSpeechStreamServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextToSpeechStreamServerEvent obj1, TextToSpeechStreamServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextToSpeechStreamServerEvent o && Equals(o);
        }
    }
}
