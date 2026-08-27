
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TtsContextCreated
    {
        /// <summary>
        /// Server-side result envelope. Exactly one of `contextCreated`,<br/>
        /// `audioChunk`, `flushCompleted`, or `contextClosed` is populated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Inworld.Realtime.TtsResultEnvelope Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsContextCreated" /> class.
        /// </summary>
        /// <param name="result">
        /// Server-side result envelope. Exactly one of `contextCreated`,<br/>
        /// `audioChunk`, `flushCompleted`, or `contextClosed` is populated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsContextCreated(
            global::Inworld.Realtime.TtsResultEnvelope result)
        {
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsContextCreated" /> class.
        /// </summary>
        public TtsContextCreated()
        {
        }

    }
}