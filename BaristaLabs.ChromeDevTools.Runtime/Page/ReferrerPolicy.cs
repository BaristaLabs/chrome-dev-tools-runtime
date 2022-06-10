namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// The referring-policy used for the navigation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReferrerPolicy
    {
        [EnumMember(Value = "noReferrer")]
        NoReferrer,
        [EnumMember(Value = "noReferrerWhenDowngrade")]
        NoReferrerWhenDowngrade,
        [EnumMember(Value = "origin")]
        Origin,
        [EnumMember(Value = "originWhenCrossOrigin")]
        OriginWhenCrossOrigin,
        [EnumMember(Value = "sameOrigin")]
        SameOrigin,
        [EnumMember(Value = "strictOrigin")]
        StrictOrigin,
        [EnumMember(Value = "strictOriginWhenCrossOrigin")]
        StrictOriginWhenCrossOrigin,
        [EnumMember(Value = "unsafeUrl")]
        UnsafeUrl,
    }
}