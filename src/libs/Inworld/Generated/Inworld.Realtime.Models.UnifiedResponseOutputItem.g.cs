
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedResponseOutputItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOutputItemContentItem>? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_uninterruptible")]
        public bool? ForceUninterruptible { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseOutputItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="object"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="callId"></param>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <param name="output"></param>
        /// <param name="forceUninterruptible"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedResponseOutputItem(
            string type,
            string? @object,
            string? id,
            string? status,
            string? role,
            global::System.Collections.Generic.IList<global::Inworld.Realtime.UnifiedResponseOutputItemContentItem>? content,
            string? callId,
            string? name,
            string? arguments,
            string? output,
            bool? forceUninterruptible)
        {
            this.Object = @object;
            this.Id = id;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Status = status;
            this.Role = role;
            this.Content = content;
            this.CallId = callId;
            this.Name = name;
            this.Arguments = arguments;
            this.Output = output;
            this.ForceUninterruptible = forceUninterruptible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedResponseOutputItem" /> class.
        /// </summary>
        public UnifiedResponseOutputItem()
        {
        }

    }
}