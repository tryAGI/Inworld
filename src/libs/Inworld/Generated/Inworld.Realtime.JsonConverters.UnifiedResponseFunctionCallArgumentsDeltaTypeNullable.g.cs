#nullable enable

namespace Inworld.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnifiedResponseFunctionCallArgumentsDeltaTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDeltaType?>
    {
        /// <inheritdoc />
        public override global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDeltaType? Read(
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
                        return global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDeltaTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDeltaType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDeltaType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDeltaType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Inworld.Realtime.UnifiedResponseFunctionCallArgumentsDeltaTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
