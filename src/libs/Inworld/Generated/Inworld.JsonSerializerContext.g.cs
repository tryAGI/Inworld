
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Inworld
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Inworld.JsonConverters.LangCodeJsonConverter),

            typeof(global::Inworld.JsonConverters.LangCodeNullableJsonConverter),

            typeof(global::Inworld.JsonConverters.VoiceSourceJsonConverter),

            typeof(global::Inworld.JsonConverters.VoiceSourceNullableJsonConverter),

            typeof(global::Inworld.JsonConverters.AudioEncodingJsonConverter),

            typeof(global::Inworld.JsonConverters.AudioEncodingNullableJsonConverter),

            typeof(global::Inworld.JsonConverters.TimestampTypeJsonConverter),

            typeof(global::Inworld.JsonConverters.TimestampTypeNullableJsonConverter),

            typeof(global::Inworld.JsonConverters.ApplyTextNormalizationJsonConverter),

            typeof(global::Inworld.JsonConverters.ApplyTextNormalizationNullableJsonConverter),

            typeof(global::Inworld.JsonConverters.SttAudioEncodingJsonConverter),

            typeof(global::Inworld.JsonConverters.SttAudioEncodingNullableJsonConverter),

            typeof(global::Inworld.JsonConverters.ModalityJsonConverter),

            typeof(global::Inworld.JsonConverters.ModalityNullableJsonConverter),

            typeof(global::Inworld.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.RpcStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.LangCode), TypeInfoPropertyName = "LangCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.VoiceSource), TypeInfoPropertyName = "VoiceSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.AudioEncoding), TypeInfoPropertyName = "AudioEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.TimestampType), TypeInfoPropertyName = "TimestampType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.ApplyTextNormalization), TypeInfoPropertyName = "ApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.AudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.SynthesizeSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Phone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.PhoneticDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.Phone>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.WordAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.PhoneticDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.CharacterAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.TimestampInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.SynthesizeSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.UpdateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.VoiceSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.AudioProcessingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.CloneVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.VoiceSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.ValidationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.ValidatedAudioSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.ValidationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.CloneVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.ValidatedAudioSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.VoiceDesignConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.DesignVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.PreviewVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.DesignVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.PreviewVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.PublishVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.SttAudioEncoding), TypeInfoPropertyName = "SttAudioEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.VoiceProfileConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.TranscribeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.AudioData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.TranscribeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.WordTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Transcription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.WordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.TranscribeUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.TranscribeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Modality), TypeInfoPropertyName = "Modality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.ModelPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.ModelCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.ModelSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.Modality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inworld.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inworld.LangCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Phone>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.PhoneticDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.VoiceSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.ValidationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.ValidatedAudioSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.PreviewVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.WordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Modality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inworld.LangCode>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}