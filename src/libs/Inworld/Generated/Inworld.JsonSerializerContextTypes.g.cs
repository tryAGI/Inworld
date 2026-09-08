
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Inworld
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Inworld.RpcStatus? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.LangCode? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.VoiceSource? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Voice? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.AudioEncoding? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.TimestampType? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.ApplyTextNormalization? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.DeliveryMode? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.AudioConfig? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.SynthesizeSpeechRequest? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.SynthesisContext? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.PreviousSynthesisRequest? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.PreviousSynthesisRequest>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Phone? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.PhoneticDetail? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Phone>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.WordAlignment? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.PhoneticDetail>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.CharacterAlignment? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.TimestampInfo? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Usage? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.SynthesizeSpeechResponse? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.ListVoicesResponse? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Voice>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.UpdateVoiceRequest? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.VoiceSample? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.AudioProcessingConfig? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.CloneVoiceRequest? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.VoiceSample>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.ValidationMessage? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.ValidatedAudioSample? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.ValidationMessage>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.CloneVoiceResponse? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.ValidatedAudioSample>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.VoiceDesignConfig? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.DesignPromptMode? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.DesignVoiceRequest? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.PreviewVoice? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.DesignVoiceResponse? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.PreviewVoice>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.PublishVoiceRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.SttAudioEncoding? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.VoiceProfileConfig? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.TranscribeConfig? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.AudioData? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.TranscribeRequest? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.WordTimestamp? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Transcription? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.WordTimestamp>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.TranscribeUsage? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.TranscribeResponse? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Modality? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.ModelPricing? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.ModelCapabilities? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.ModelSpec? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Modality>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.Model? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inworld.ListModelsResponse? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.Model>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inworld.LangCode>? Type68 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.PreviousSynthesisRequest>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.Phone>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.PhoneticDetail>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.Voice>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.VoiceSample>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.ValidationMessage>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.ValidatedAudioSample>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.PreviewVoice>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.WordTimestamp>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.Modality>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.Model>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inworld.LangCode>? ListType14 { get; set; }
    }
}