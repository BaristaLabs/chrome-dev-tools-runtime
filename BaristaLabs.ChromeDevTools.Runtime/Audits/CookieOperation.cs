namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// CookieOperation
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CookieOperation
    {
        [EnumMember(Value = "SetCookie")]
        SetCookie,
        [EnumMember(Value = "ReadCookie")]
        ReadCookie,
    }
}