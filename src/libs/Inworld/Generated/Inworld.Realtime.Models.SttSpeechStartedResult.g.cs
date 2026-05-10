
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttSpeechStartedResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speechStarted")]
        public global::Inworld.Realtime.SttSpeechStartedData? SpeechStarted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttSpeechStartedResult" /> class.
        /// </summary>
        /// <param name="speechStarted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttSpeechStartedResult(
            global::Inworld.Realtime.SttSpeechStartedData? speechStarted)
        {
            this.SpeechStarted = speechStarted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttSpeechStartedResult" /> class.
        /// </summary>
        public SttSpeechStartedResult()
        {
        }

    }
}