namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents the cookie's 'Priority' status:
    /// https://tools.ietf.org/html/draft-west-cookie-priority-00
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CookiePriority
    {
        [EnumMember(Value = "Low")]
        Low,
        [EnumMember(Value = "Medium")]
        Medium,
        [EnumMember(Value = "High")]
        High,
    }
}