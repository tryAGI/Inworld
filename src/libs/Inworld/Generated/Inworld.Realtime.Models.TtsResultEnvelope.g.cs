
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// |
    /// </summary>
    public sealed partial class TtsResultEnvelope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextId")]
        public string? ContextId { get; set; }

        /// <summary>
        /// gRPC-style status envelope included in every server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Inworld.Realtime.StreamStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextCreated")]
        public global::Inworld.Realtime.TtsCreateContextParams? ContextCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioChunk")]
        public global::Inworld.Realtime.TtsAudioChunkData? AudioChunk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flushCompleted")]
        public object? FlushCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextClosed")]
        public object? ContextClosed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsResultEnvelope" /> class.
        /// </summary>
        /// <param name="contextId"></param>
        /// <param name="status">
        /// gRPC-style status envelope included in every server event.
        /// </param>
        /// <param name="contextCreated"></param>
        /// <param name="audioChunk"></param>
        /// <param name="flushCompleted"></param>
        /// <param name="contextClosed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsResultEnvelope(
            string? contextId,
            global::Inworld.Realtime.StreamStatus? status,
            global::Inworld.Realtime.TtsCreateContextParams? contextCreated,
            global::Inworld.Realtime.TtsAudioChunkData? audioChunk,
            object? flushCompleted,
            object? contextClosed)
        {
            this.ContextId = contextId;
            this.Status = status;
            this.ContextCreated = contextCreated;
            this.AudioChunk = audioChunk;
            this.FlushCompleted = flushCompleted;
            this.ContextClosed = contextClosed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsResultEnvelope" /> class.
        /// </summary>
        public TtsResultEnvelope()
        {
        }

    }
}