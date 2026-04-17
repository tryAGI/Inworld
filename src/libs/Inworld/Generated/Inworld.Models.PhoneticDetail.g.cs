
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Phonetic detail for a word. Available only with TTS 1.5 models and WORD timestamps.
    /// </summary>
    public sealed partial class PhoneticDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordIndex")]
        public int? WordIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phones")]
        public global::System.Collections.Generic.IList<global::Inworld.Phone>? Phones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPartial")]
        public bool? IsPartial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneticDetail" /> class.
        /// </summary>
        /// <param name="wordIndex"></param>
        /// <param name="phones"></param>
        /// <param name="isPartial"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneticDetail(
            int? wordIndex,
            global::System.Collections.Generic.IList<global::Inworld.Phone>? phones,
            bool? isPartial)
        {
            this.WordIndex = wordIndex;
            this.Phones = phones;
            this.IsPartial = isPartial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneticDetail" /> class.
        /// </summary>
        public PhoneticDetail()
        {
        }
    }
}