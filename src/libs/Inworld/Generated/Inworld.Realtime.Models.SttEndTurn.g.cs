
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttEndTurn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_turn")]
        public object? EndTurn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttEndTurn" /> class.
        /// </summary>
        /// <param name="endTurn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttEndTurn(
            object? endTurn)
        {
            this.EndTurn = endTurn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttEndTurn" /> class.
        /// </summary>
        public SttEndTurn()
        {
        }
    }
}