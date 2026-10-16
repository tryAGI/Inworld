
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnifiedSessionAudioOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Inworld.Realtime.JsonConverters.OneOfJsonConverter<string, global::Inworld.Realtime.UnifiedAudioFormat>))]
        public global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedAudioFormat>? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedSessionAudioOutput" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="voice"></param>
        /// <param name="model"></param>
        /// <param name="speed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedSessionAudioOutput(
            global::Inworld.Realtime.OneOf<string, global::Inworld.Realtime.UnifiedAudioFormat>? format,
            string? voice,
            string? model,
            double? speed)
        {
            this.Format = format;
            this.Voice = voice;
            this.Model = model;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedSessionAudioOutput" /> class.
        /// </summary>
        public UnifiedSessionAudioOutput()
        {
        }

    }
}