
#nullable enable

namespace Inworld
{
    public partial class TextToSpeechClient
    {


        private static readonly global::Inworld.EndPointSecurityRequirement s_SynthesizeSpeechStreamSecurityRequirement0 =
            new global::Inworld.EndPointSecurityRequirement
            {
                Authorizations = new global::Inworld.EndPointAuthorizationRequirement[]
                {                    new global::Inworld.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Inworld.EndPointSecurityRequirement[] s_SynthesizeSpeechStreamSecurityRequirements =
            new global::Inworld.EndPointSecurityRequirement[]
            {                s_SynthesizeSpeechStreamSecurityRequirement0,
            };
        partial void PrepareSynthesizeSpeechStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Inworld.SynthesizeSpeechRequest request);
        partial void PrepareSynthesizeSpeechStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Inworld.SynthesizeSpeechRequest request);
        partial void ProcessSynthesizeSpeechStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Stream synthesized speech over HTTP<br/>
        /// Newline-delimited JSON envelopes containing audio, usage, or timestamps.<br/>
        /// Read until EOF, including timestamp-only messages after audio. Check each<br/>
        /// envelope's error field as well as the HTTP status. Audio chunks are<br/>
        /// independently base64 encoded; framing depends on the selected encoding.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Inworld.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Inworld.SynthesizeSpeechStreamResponse> SynthesizeSpeechStreamAsync(

            global::Inworld.SynthesizeSpeechRequest request,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSynthesizeSpeechStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Inworld.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SynthesizeSpeechStreamSecurityRequirements,
                operationName: "SynthesizeSpeechStreamAsync");

            using var __timeoutCancellationTokenSource = global::Inworld.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Inworld.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Inworld.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Inworld.PathBuilder(
                                path: "/tts/v1/voice:stream",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Inworld.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Inworld.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSynthesizeSpeechStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Inworld.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Inworld.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SynthesizeSpeechStream",
                                methodName: "SynthesizeSpeechStreamAsync",
                                pathTemplate: "\"/tts/v1/voice:stream\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Inworld.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Inworld.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Inworld.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SynthesizeSpeechStream",
                                methodName: "SynthesizeSpeechStreamAsync",
                                pathTemplate: "\"/tts/v1/voice:stream\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Inworld.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Inworld.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Inworld.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Inworld.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Inworld.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SynthesizeSpeechStream",
                                methodName: "SynthesizeSpeechStreamAsync",
                                pathTemplate: "\"/tts/v1/voice:stream\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Inworld.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessSynthesizeSpeechStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Inworld.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Inworld.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SynthesizeSpeechStream",
                                methodName: "SynthesizeSpeechStreamAsync",
                                pathTemplate: "\"/tts/v1/voice:stream\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Inworld.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Inworld.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SynthesizeSpeechStream",
                                methodName: "SynthesizeSpeechStreamAsync",
                                pathTemplate: "\"/tts/v1/voice:stream\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);
                                }
                                catch (global::System.Exception)
                                {
                                }

                                throw global::Inworld.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            using var __reader = new global::System.IO.StreamReader(__stream);

                            while (true)
                            {
                                __effectiveCancellationToken.ThrowIfCancellationRequested();
                #if NET8_0_OR_GREATER
                                var __content = await __reader.ReadLineAsync(__effectiveCancellationToken).ConfigureAwait(false);
                #else
                                var __content = await __reader.ReadLineAsync().ConfigureAwait(false);
                #endif
                                if (__content is null)
                                {
                                    break;
                                }
                                if (global::System.String.IsNullOrWhiteSpace(__content))
                                {
                                    continue;
                                }

                                var __streamedResponse = global::Inworld.SynthesizeSpeechStreamResponse.FromJson(__content, JsonSerializerContext) ??
                                                       throw global::Inworld.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Stream synthesized speech over HTTP<br/>
        /// Newline-delimited JSON envelopes containing audio, usage, or timestamps.<br/>
        /// Read until EOF, including timestamp-only messages after audio. Check each<br/>
        /// envelope's error field as well as the HTTP status. Audio chunks are<br/>
        /// independently base64 encoded; framing depends on the selected encoding.
        /// </summary>
        /// <param name="text">
        /// The text to synthesize. Maximum 2,000 characters.
        /// </param>
        /// <param name="voiceId">
        /// Voice identifier.
        /// </param>
        /// <param name="modelId">
        /// Model identifier. Use `inworld-tts-2` for flagship quality and steering, or `inworld-tts-2-flash` for the lowest latency and cost.
        /// </param>
        /// <param name="audioConfig">
        /// Audio output configuration for TTS synthesis.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature in the range (0, 2]. Defaults to 1.0.
        /// </param>
        /// <param name="timestampType">
        /// Timestamp granularity returned alongside TTS audio.
        /// </param>
        /// <param name="applyTextNormalization">
        /// Whether text normalization is applied before synthesis.
        /// </param>
        /// <param name="deliveryMode">
        /// Variation and expressiveness mode for Realtime TTS-2.
        /// </param>
        /// <param name="language">
        /// BCP-47 language tag (for example `en-US`, `fr-FR`, or `ja-JP`). Omit to auto-detect the input language.
        /// </param>
        /// <param name="instruction">
        /// English speaking-style direction for the whole request. Supported by `inworld-tts-2`; inline bracketed instructions can override it.
        /// </param>
        /// <param name="enhanceGeneration">
        /// Apply denoising to reduce background noise and synthesis artifacts.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="synthesisContext">
        /// Prior synthesis requests used to improve continuity for short or ambiguous text. Context text is not billed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Inworld.SynthesizeSpeechStreamResponse> SynthesizeSpeechStreamAsync(
            string text,
            string voiceId,
            string modelId,
            global::Inworld.AudioConfig? audioConfig = default,
            double? temperature = default,
            global::Inworld.TimestampType? timestampType = default,
            global::Inworld.ApplyTextNormalization? applyTextNormalization = default,
            global::Inworld.DeliveryMode? deliveryMode = default,
            string? language = default,
            string? instruction = default,
            bool? enhanceGeneration = default,
            global::Inworld.SynthesisContext? synthesisContext = default,
            global::Inworld.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Inworld.SynthesizeSpeechRequest
            {
                Text = text,
                VoiceId = voiceId,
                ModelId = modelId,
                AudioConfig = audioConfig,
                Temperature = temperature,
                TimestampType = timestampType,
                ApplyTextNormalization = applyTextNormalization,
                DeliveryMode = deliveryMode,
                Language = language,
                Instruction = instruction,
                EnhanceGeneration = enhanceGeneration,
                SynthesisContext = synthesisContext,
            };

            var __enumerable = SynthesizeSpeechStreamAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}