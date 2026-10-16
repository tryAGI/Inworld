#nullable enable

namespace Inworld.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnifiedResponseSpeakAcknowledgedTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedType?>
    {
        /// <inheritdoc />
        public override global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedType? Read(
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
                        return global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Inworld.Realtime.UnifiedResponseSpeakAcknowledgedTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
