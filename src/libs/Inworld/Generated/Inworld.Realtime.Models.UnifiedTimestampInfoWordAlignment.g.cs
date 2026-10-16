
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedTimestampInfoWordAlignment
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<string>? Words { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_start_time_seconds")]
        public global::System.Collections.Generic.IList<double>? WordStartTimeSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_end_time_seconds")]
        public global::System.Collections.Generic.IList<double>? WordEndTimeSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phonetic_details")]
        public global::System.Collections.Generic.IList<object>? PhoneticDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTimestampInfoWordAlignment" /> class.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="wordStartTimeSeconds"></param>
        /// <param name="wordEndTimeSeconds"></param>
        /// <param name="phoneticDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedTimestampInfoWordAlignment(
            global::System.Collections.Generic.IList<string>? words,
            global::System.Collections.Generic.IList<double>? wordStartTimeSeconds,
            global::System.Collections.Generic.IList<double>? wordEndTimeSeconds,
            global::System.Collections.Generic.IList<object>? phoneticDetails)
        {
            this.Words = words;
            this.WordStartTimeSeconds = wordStartTimeSeconds;
            this.WordEndTimeSeconds = wordEndTimeSeconds;
            this.PhoneticDetails = phoneticDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedTimestampInfoWordAlignment" /> class.
        /// </summary>
        public UnifiedTimestampInfoWordAlignment()
        {
        }

    }
}