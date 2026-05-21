
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Inline audio payload.
    /// </summary>
    public sealed partial class AudioData
    {
        /// <summary>
        /// Base64-encoded audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public byte[]? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioData" /> class.
        /// </summary>
        /// <param name="content">
        /// Base64-encoded audio bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioData(
            byte[]? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioData" /> class.
        /// </summary>
        public AudioData()
        {
        }

    }
}