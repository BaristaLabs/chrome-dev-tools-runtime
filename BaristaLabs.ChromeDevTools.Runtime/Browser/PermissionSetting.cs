namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// PermissionSetting
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PermissionSetting
    {
        [EnumMember(Value = "granted")]
        Granted,
        [EnumMember(Value = "denied")]
        Denied,
        [EnumMember(Value = "prompt")]
        Prompt,
    }
}