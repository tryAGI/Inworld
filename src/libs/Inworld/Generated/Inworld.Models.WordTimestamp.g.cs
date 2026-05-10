
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordTimestamp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimeMs")]
        public int? StartTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTimeMs")]
        public int? EndTimeMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordTimestamp" /> class.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="startTimeMs"></param>
        /// <param name="endTimeMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordTimestamp(
            string? word,
            int? startTimeMs,
            int? endTimeMs)
        {
            this.Word = word;
            this.StartTimeMs = startTimeMs;
            this.EndTimeMs = endTimeMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordTimestamp" /> class.
        /// </summary>
        public WordTimestamp()
        {
        }

    }
}