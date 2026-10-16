#nullable enable

namespace Inworld.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnifiedInputAudioBufferTimeoutTriggeredTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggeredType>
    {
        /// <inheritdoc />
        public override global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggeredType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggeredTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggeredType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggeredType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggeredType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Inworld.Realtime.UnifiedInputAudioBufferTimeoutTriggeredTypeExtensions.ToValueString(value));
        }
    }
}
