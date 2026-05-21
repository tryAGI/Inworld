
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttCloseStream
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("close_stream")]
        public object? CloseStream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttCloseStream" /> class.
        /// </summary>
        /// <param name="closeStream"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttCloseStream(
            object? closeStream)
        {
            this.CloseStream = closeStream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttCloseStream" /> class.
        /// </summary>
        public SttCloseStream()
        {
        }

    }
}