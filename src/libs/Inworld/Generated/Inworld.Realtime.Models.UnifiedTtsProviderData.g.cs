
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedTtsProviderData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmenter_strategy")]
        public string? SegmenterStrategy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steering_handling")]
        public string? SteeringHandling { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery_mode")]
        public string? DeliveryMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversational")]
        public bool? Conversational { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_turn_mode")]
        public string? UserTurnMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_type")]
        public string? TimestampType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_transport_strategy")]
        public string? TimestampTransportStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTtsProviderData" /> class.
        /// </summary>
        /// <param name="segmenterStrategy"></param>
        /// <param name="steeringHandling"></param>
        /// <param name="language"></param>
        /// <param name="deliveryMode"></param>
        /// <param name="conversational"></param>
        /// <param name="userTurnMode"></param>
        /// <param name="timestampType"></param>
        /// <param name="timestampTransportStrategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedTtsProviderData(
            string? segmenterStrategy,
            string? steeringHandling,
            string? language,
            string? deliveryMode,
            bool? conversational,
            string? userTurnMode,
            string? timestampType,
            string? timestampTransportStrategy)
        {
            this.SegmenterStrategy = segmenterStrategy;
            this.SteeringHandling = steeringHandling;
            this.Language = language;
            this.DeliveryMode = deliveryMode;
            this.Conversational = conversational;
            this.UserTurnMode = userTurnMode;
            this.TimestampType = timestampType;
            this.TimestampTransportStrategy = timestampTransportStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTtsProviderData" /> class.
        /// </summary>
        public UnifiedTtsProviderData()
        {
        }

    }
}