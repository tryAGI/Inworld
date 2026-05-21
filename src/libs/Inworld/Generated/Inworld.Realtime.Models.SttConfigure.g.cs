
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SttConfigure
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribe_config")]
        public global::Inworld.Realtime.SttTranscribeConfigParams? TranscribeConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SttConfigure" /> class.
        /// </summary>
        /// <param name="transcribeConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SttConfigure(
            global::Inworld.Realtime.SttTranscribeConfigParams? transcribeConfig)
        {
            this.TranscribeConfig = transcribeConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SttConfigure" /> class.
        /// </summary>
        public SttConfigure()
        {
        }

    }
}