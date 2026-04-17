
#nullable enable

namespace Inworld
{
    /// <summary>
    /// Inworld AI is a realtime voice and AI platform providing low-latency<br/>
    /// text-to-speech, speech-to-text, voice cloning, voice design, and LLM routing<br/>
    /// for interactive applications.<br/>
    /// This SDK covers the REST surface: TTS synthesis, STT transcription, Voice<br/>
    /// management (list, get, clone, design, publish, update, delete), and model<br/>
    /// discovery.<br/>
    /// **Excluded from this SDK:**<br/>
    ///   - WebSocket/Realtime streaming (`/tts/v1/voice:streamBidirectional`,<br/>
    ///     `/stt/v1/transcribe:streamBidirectional`, Realtime API)<br/>
    ///   - OpenAI-compatible Chat Completions (`/v1/chat/completions` — use<br/>
    ///     `tryAGI.OpenAI` with Inworld as a CustomProvider)<br/>
    ///   - Router long-running management endpoints<br/>
    /// **Authentication:** `Authorization: Basic &lt;API_KEY&gt;` where `&lt;API_KEY&gt;` is<br/>
    /// the already-Base64-encoded API key from the Inworld Portal.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IInworldClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Inworld.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Discover available LLM models.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// Transcribe speech to text.
        /// </summary>
        public SpeechToTextClient SpeechToText { get; }

        /// <summary>
        /// Synthesize speech from text.
        /// </summary>
        public TextToSpeechClient TextToSpeech { get; }

        /// <summary>
        /// Manage voices — list, get, clone, design, publish, update, delete.
        /// </summary>
        public VoicesClient Voices { get; }

    }
}