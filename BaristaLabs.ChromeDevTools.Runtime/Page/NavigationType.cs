namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type of a frameNavigated event.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NavigationType
    {
        [EnumMember(Value = "Navigation")]
        Navigation,
        [EnumMember(Value = "BackForwardCacheRestore")]
        BackForwardCacheRestore,
    }
}