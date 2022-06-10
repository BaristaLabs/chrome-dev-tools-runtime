namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Document compatibility mode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompatibilityMode
    {
        [EnumMember(Value = "QuirksMode")]
        QuirksMode,
        [EnumMember(Value = "LimitedQuirksMode")]
        LimitedQuirksMode,
        [EnumMember(Value = "NoQuirksMode")]
        NoQuirksMode,
    }
}