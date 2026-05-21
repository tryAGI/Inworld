#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Inworld.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class TextToSpeechStreamServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inworld.Realtime.TextToSpeechStreamServerEvent>
    {
        /// <inheritdoc />
        public override global::Inworld.Realtime.TextToSpeechStreamServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("result")) __score0++;
            if (__jsonProps.Contains("result.audioChunk")) __score0++;
            if (__jsonProps.Contains("result.contextClosed")) __score0++;
            if (__jsonProps.Contains("result.contextCreated")) __score0++;
            if (__jsonProps.Contains("result.contextId")) __score0++;
            if (__jsonProps.Contains("result.flushCompleted")) __score0++;
            if (__jsonProps.Contains("result.status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("result")) __score1++;
            if (__jsonProps.Contains("result.audioChunk")) __score1++;
            if (__jsonProps.Contains("result.contextClosed")) __score1++;
            if (__jsonProps.Contains("result.contextCreated")) __score1++;
            if (__jsonProps.Contains("result.contextId")) __score1++;
            if (__jsonProps.Contains("result.flushCompleted")) __score1++;
            if (__jsonProps.Contains("result.status")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("result")) __score2++;
            if (__jsonProps.Contains("result.audioChunk")) __score2++;
            if (__jsonProps.Contains("result.contextClosed")) __score2++;
            if (__jsonProps.Contains("result.contextCreated")) __score2++;
            if (__jsonProps.Contains("result.contextId")) __score2++;
            if (__jsonProps.Contains("result.flushCompleted")) __score2++;
            if (__jsonProps.Contains("result.status")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("result")) __score3++;
            if (__jsonProps.Contains("result.audioChunk")) __score3++;
            if (__jsonProps.Contains("result.contextClosed")) __score3++;
            if (__jsonProps.Contains("result.contextCreated")) __score3++;
            if (__jsonProps.Contains("result.contextId")) __score3++;
            if (__jsonProps.Contains("result.flushCompleted")) __score3++;
            if (__jsonProps.Contains("result.status")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Inworld.Realtime.TtsContextCreated? ttsContextCreated = default;
            global::Inworld.Realtime.TtsAudioChunk? ttsAudioChunk = default;
            global::Inworld.Realtime.TtsFlushCompleted? ttsFlushCompleted = default;
            global::Inworld.Realtime.TtsContextClosed? ttsContextClosed = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsContextCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsContextCreated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsContextCreated).Name}");
                        ttsContextCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsAudioChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsAudioChunk> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsAudioChunk).Name}");
                        ttsAudioChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsFlushCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsFlushCompleted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsFlushCompleted).Name}");
                        ttsFlushCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsContextClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsContextClosed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsContextClosed).Name}");
                        ttsContextClosed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (ttsContextCreated == null && ttsAudioChunk == null && ttsFlushCompleted == null && ttsContextClosed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsContextCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsContextCreated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsContextCreated).Name}");
                    ttsContextCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (ttsContextCreated == null && ttsAudioChunk == null && ttsFlushCompleted == null && ttsContextClosed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsAudioChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsAudioChunk> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsAudioChunk).Name}");
                    ttsAudioChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (ttsContextCreated == null && ttsAudioChunk == null && ttsFlushCompleted == null && ttsContextClosed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsFlushCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsFlushCompleted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsFlushCompleted).Name}");
                    ttsFlushCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (ttsContextCreated == null && ttsAudioChunk == null && ttsFlushCompleted == null && ttsContextClosed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsContextClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsContextClosed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsContextClosed).Name}");
                    ttsContextClosed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Inworld.Realtime.TextToSpeechStreamServerEvent(
                ttsContextCreated,

                ttsAudioChunk,

                ttsFlushCompleted,

                ttsContextClosed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Inworld.Realtime.TextToSpeechStreamServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTtsContextCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsContextCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsContextCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsContextCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TtsContextCreated!, typeInfo);
            }
            else if (value.IsTtsAudioChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsAudioChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsAudioChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsAudioChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TtsAudioChunk!, typeInfo);
            }
            else if (value.IsTtsFlushCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsFlushCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsFlushCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsFlushCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TtsFlushCompleted!, typeInfo);
            }
            else if (value.IsTtsContextClosed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inworld.Realtime.TtsContextClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inworld.Realtime.TtsContextClosed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inworld.Realtime.TtsContextClosed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TtsContextClosed!, typeInfo);
            }
        }
    }
}