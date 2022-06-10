namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Browser command ids used by executeBrowserCommand.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BrowserCommandId
    {
        [EnumMember(Value = "openTabSearch")]
        OpenTabSearch,
        [EnumMember(Value = "closeTabSearch")]
        CloseTabSearch,
    }
}