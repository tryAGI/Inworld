
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Standard gRPC-style error envelope.
    /// </summary>
    public sealed partial class RpcStatus
    {
        /// <summary>
        /// gRPC status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Optional list of structured error details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::System.Collections.Generic.IList<object>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RpcStatus" /> class.
        /// </summary>
        /// <param name="code">
        /// gRPC status code.
        /// </param>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="details">
        /// Optional list of structured error details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RpcStatus(
            int? code,
            string? message,
            global::System.Collections.Generic.IList<object>? details)
        {
            this.Code = code;
            this.Message = message;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RpcStatus" /> class.
        /// </summary>
        public RpcStatus()
        {
        }

    }
}