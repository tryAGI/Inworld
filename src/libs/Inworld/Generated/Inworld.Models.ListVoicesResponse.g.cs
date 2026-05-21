
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListVoicesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        public global::System.Collections.Generic.IList<global::Inworld.Voice>? Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponse" /> class.
        /// </summary>
        /// <param name="voices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVoicesResponse(
            global::System.Collections.Generic.IList<global::Inworld.Voice>? voices)
        {
            this.Voices = voices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponse" /> class.
        /// </summary>
        public ListVoicesResponse()
        {
        }

    }
}