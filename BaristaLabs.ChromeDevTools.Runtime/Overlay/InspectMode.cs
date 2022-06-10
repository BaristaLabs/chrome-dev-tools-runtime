namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// InspectMode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InspectMode
    {
        [EnumMember(Value = "searchForNode")]
        SearchForNode,
        [EnumMember(Value = "searchForUAShadowDOM")]
        SearchForUAShadowDOM,
        [EnumMember(Value = "captureAreaScreenshot")]
        CaptureAreaScreenshot,
        [EnumMember(Value = "showDistances")]
        ShowDistances,
        [EnumMember(Value = "none")]
        None,
    }
}