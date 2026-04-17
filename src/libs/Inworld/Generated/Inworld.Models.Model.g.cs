
#nullable enable

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// Fully-qualified model id (e.g. `inworld/inworld-tts-1.5-max`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelCreator")]
        public string? ModelCreator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::Inworld.ModelPricing? Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        public global::Inworld.ModelSpec? Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSupported")]
        public bool? IsSupported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="model1">
        /// Fully-qualified model id (e.g. `inworld/inworld-tts-1.5-max`).
        /// </param>
        /// <param name="provider"></param>
        /// <param name="modelCreator"></param>
        /// <param name="pricing"></param>
        /// <param name="spec"></param>
        /// <param name="isSupported"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            string? model1,
            string? provider,
            string? modelCreator,
            global::Inworld.ModelPricing? pricing,
            global::Inworld.ModelSpec? spec,
            bool? isSupported)
        {
            this.Model1 = model1;
            this.Provider = provider;
            this.ModelCreator = modelCreator;
            this.Pricing = pricing;
            this.Spec = spec;
            this.IsSupported = isSupported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}