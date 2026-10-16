#nullable enable

namespace Inworld.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnifiedResponseOutputAudioDeltaTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inworld.Realtime.UnifiedResponseOutputAudioDeltaType>
    {
        /// <inheritdoc />
        public override global::Inworld.Realtime.UnifiedResponseOutputAudioDeltaType Read(
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
                        return global::Inworld.Realtime.UnifiedResponseOutputAudioDeltaTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Inworld.Realtime.UnifiedResponseOutputAudioDeltaType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Inworld.Realtime.UnifiedResponseOutputAudioDeltaType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Inworld.Realtime.UnifiedResponseOutputAudioDeltaType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Inworld.Realtime.UnifiedResponseOutputAudioDeltaTypeExtensions.ToValueString(value));
        }
    }
}
