
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedResponseCreateTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedResponseCreateType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::Inworld.Realtime.UnifiedResponseOptions? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseCreate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseCreate(
            global::Inworld.Realtime.UnifiedResponseCreateType type,
            string? eventId,
            global::Inworld.Realtime.UnifiedResponseOptions? response)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseCreate" /> class.
        /// </summary>
        public UnifiedResponseCreate()
        {
        }

    }
}