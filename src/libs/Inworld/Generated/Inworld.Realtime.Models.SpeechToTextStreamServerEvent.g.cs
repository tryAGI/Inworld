#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SpeechToTextStreamServerEvent : global::System.IEquatable<SpeechToTextStreamServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.SttTranscription? SttTranscription { get; init; }
#else
        public global::Inworld.Realtime.SttTranscription? SttTranscription { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SttTranscription))]
#endif
        public bool IsSttTranscription => SttTranscription != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.SttUsage? SttUsage { get; init; }
#else
        public global::Inworld.Realtime.SttUsage? SttUsage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SttUsage))]
#endif
        public bool IsSttUsage => SttUsage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inworld.Realtime.SttSpeechStarted? SttStarted { get; init; }
#else
        public global::Inworld.Realtime.SttSpeechStarted? SttStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SttStarted))]
#endif
        public bool IsSttStarted => SttStarted != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeechToTextStreamServerEvent(global::Inworld.Realtime.SttTranscription value) => new SpeechToTextStreamServerEvent((global::Inworld.Realtime.SttTranscription?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Inworld.Realtime.SttTranscription?(SpeechToTextStreamServerEvent @this) => @this.SttTranscription;

        /// <summary>
        /// 
        /// </summary>
        public SpeechToTextStreamServerEvent(global::Inworld.Realtime.SttTranscription? value)
        {
            SttTranscription = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeechToTextStreamServerEvent(global::Inworld.Realtime.SttUsage value) => new SpeechToTextStreamServerEvent((global::Inworld.Realtime.SttUsage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Inworld.Realtime.SttUsage?(SpeechToTextStreamServerEvent @this) => @this.SttUsage;

        /// <summary>
        /// 
        /// </summary>
        public SpeechToTextStreamServerEvent(global::Inworld.Realtime.SttUsage? value)
        {
            SttUsage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeechToTextStreamServerEvent(global::Inworld.Realtime.SttSpeechStarted value) => new SpeechToTextStreamServerEvent((global::Inworld.Realtime.SttSpeechStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Inworld.Realtime.SttSpeechStarted?(SpeechToTextStreamServerEvent @this) => @this.SttStarted;

        /// <summary>
        /// 
        /// </summary>
        public SpeechToTextStreamServerEvent(global::Inworld.Realtime.SttSpeechStarted? value)
        {
            SttStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SpeechToTextStreamServerEvent(
            global::Inworld.Realtime.SttTranscription? sttTranscription,
            global::Inworld.Realtime.SttUsage? sttUsage,
            global::Inworld.Realtime.SttSpeechStarted? sttStarted
            )
        {
            SttTranscription = sttTranscription;
            SttUsage = sttUsage;
            SttStarted = sttStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SttStarted as object ??
            SttUsage as object ??
            SttTranscription as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SttTranscription?.ToString() ??
            SttUsage?.ToString() ??
            SttStarted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSttTranscription && !IsSttUsage && !IsSttStarted || !IsSttTranscription && IsSttUsage && !IsSttStarted || !IsSttTranscription && !IsSttUsage && IsSttStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Inworld.Realtime.SttTranscription?, TResult>? sttTranscription = null,
            global::System.Func<global::Inworld.Realtime.SttUsage?, TResult>? sttUsage = null,
            global::System.Func<global::Inworld.Realtime.SttSpeechStarted?, TResult>? sttStarted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSttTranscription && sttTranscription != null)
            {
                return sttTranscription(SttTranscription!);
            }
            else if (IsSttUsage && sttUsage != null)
            {
                return sttUsage(SttUsage!);
            }
            else if (IsSttStarted && sttStarted != null)
            {
                return sttStarted(SttStarted!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Inworld.Realtime.SttTranscription?>? sttTranscription = null,
            global::System.Action<global::Inworld.Realtime.SttUsage?>? sttUsage = null,
            global::System.Action<global::Inworld.Realtime.SttSpeechStarted?>? sttStarted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSttTranscription)
            {
                sttTranscription?.Invoke(SttTranscription!);
            }
            else if (IsSttUsage)
            {
                sttUsage?.Invoke(SttUsage!);
            }
            else if (IsSttStarted)
            {
                sttStarted?.Invoke(SttStarted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SttTranscription,
                typeof(global::Inworld.Realtime.SttTranscription),
                SttUsage,
                typeof(global::Inworld.Realtime.SttUsage),
                SttStarted,
                typeof(global::Inworld.Realtime.SttSpeechStarted),
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
        public bool Equals(SpeechToTextStreamServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.SttTranscription?>.Default.Equals(SttTranscription, other.SttTranscription) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.SttUsage?>.Default.Equals(SttUsage, other.SttUsage) &&
                global::System.Collections.Generic.EqualityComparer<global::Inworld.Realtime.SttSpeechStarted?>.Default.Equals(SttStarted, other.SttStarted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SpeechToTextStreamServerEvent obj1, SpeechToTextStreamServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpeechToTextStreamServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SpeechToTextStreamServerEvent obj1, SpeechToTextStreamServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeechToTextStreamServerEvent o && Equals(o);
        }
    }
}
