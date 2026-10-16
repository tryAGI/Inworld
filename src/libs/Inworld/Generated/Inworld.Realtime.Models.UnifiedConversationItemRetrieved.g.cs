
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedConversationItemRetrieved
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.UnifiedConversationItemRetrievedTypeJsonConverter))]
        public global::Inworld.Realtime.UnifiedConversationItemRetrievedType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerData")]
        public global::Inworld.Realtime.UnifiedProviderData? ProviderData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedConversationItemRetrieved" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="type"></param>
        /// <param name="providerData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedConversationItemRetrieved(
            string eventId,
            global::Inworld.Realtime.UnifiedConversationItemRetrievedType type,
            global::Inworld.Realtime.UnifiedProviderData? providerData)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ProviderData = providerData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedConversationItemRetrieved" /> class.
        /// </summary>
        public UnifiedConversationItemRetrieved()
        {
        }

    }
}