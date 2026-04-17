
#nullable enable

namespace Inworld
{
    /// <summary>
    /// BCP-47-like language code used by Inworld voice APIs.
    /// </summary>
    public enum LangCode
    {
        /// <summary>
        /// 
        /// </summary>
        ArSa,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        DeDe,
        /// <summary>
        /// 
        /// </summary>
        EnUs,
        /// <summary>
        /// 
        /// </summary>
        EsEs,
        /// <summary>
        /// 
        /// </summary>
        FrFr,
        /// <summary>
        /// 
        /// </summary>
        HeIl,
        /// <summary>
        /// 
        /// </summary>
        HiIn,
        /// <summary>
        /// 
        /// </summary>
        ItIt,
        /// <summary>
        /// 
        /// </summary>
        JaJp,
        /// <summary>
        /// 
        /// </summary>
        KoKr,
        /// <summary>
        /// 
        /// </summary>
        NlNl,
        /// <summary>
        /// 
        /// </summary>
        PlPl,
        /// <summary>
        /// 
        /// </summary>
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        RuRu,
        /// <summary>
        /// 
        /// </summary>
        ZhCn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LangCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LangCode value)
        {
            return value switch
            {
                LangCode.ArSa => "AR_SA",
                LangCode.Auto => "AUTO",
                LangCode.DeDe => "DE_DE",
                LangCode.EnUs => "EN_US",
                LangCode.EsEs => "ES_ES",
                LangCode.FrFr => "FR_FR",
                LangCode.HeIl => "HE_IL",
                LangCode.HiIn => "HI_IN",
                LangCode.ItIt => "IT_IT",
                LangCode.JaJp => "JA_JP",
                LangCode.KoKr => "KO_KR",
                LangCode.NlNl => "NL_NL",
                LangCode.PlPl => "PL_PL",
                LangCode.PtBr => "PT_BR",
                LangCode.RuRu => "RU_RU",
                LangCode.ZhCn => "ZH_CN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LangCode? ToEnum(string value)
        {
            return value switch
            {
                "AR_SA" => LangCode.ArSa,
                "AUTO" => LangCode.Auto,
                "DE_DE" => LangCode.DeDe,
                "EN_US" => LangCode.EnUs,
                "ES_ES" => LangCode.EsEs,
                "FR_FR" => LangCode.FrFr,
                "HE_IL" => LangCode.HeIl,
                "HI_IN" => LangCode.HiIn,
                "IT_IT" => LangCode.ItIt,
                "JA_JP" => LangCode.JaJp,
                "KO_KR" => LangCode.KoKr,
                "NL_NL" => LangCode.NlNl,
                "PL_PL" => LangCode.PlPl,
                "PT_BR" => LangCode.PtBr,
                "RU_RU" => LangCode.RuRu,
                "ZH_CN" => LangCode.ZhCn,
                _ => null,
            };
        }
    }
}