
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedTurnDetection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eagerness")]
        public string? Eagerness { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_response")]
        public bool? CreateResponse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_response")]
        public bool? InterruptResponse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_padding_ms")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_duration_ms")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_ms")]
        public int? IdleTimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTurnDetection" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eagerness"></param>
        /// <param name="createResponse"></param>
        /// <param name="interruptResponse"></param>
        /// <param name="threshold"></param>
        /// <param name="prefixPaddingMs"></param>
        /// <param name="silenceDurationMs"></param>
        /// <param name="idleTimeoutMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedTurnDetection(
            string? type,
            string? eagerness,
            bool? createResponse,
            bool? interruptResponse,
            double? threshold,
            int? prefixPaddingMs,
            int? silenceDurationMs,
            int? idleTimeoutMs)
        {
            this.Type = type;
            this.Eagerness = eagerness;
            this.CreateResponse = createResponse;
            this.InterruptResponse = interruptResponse;
            this.Threshold = threshold;
            this.PrefixPaddingMs = prefixPaddingMs;
            this.SilenceDurationMs = silenceDurationMs;
            this.IdleTimeoutMs = idleTimeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTurnDetection" /> class.
        /// </summary>
        public UnifiedTurnDetection()
        {
        }

    }
}