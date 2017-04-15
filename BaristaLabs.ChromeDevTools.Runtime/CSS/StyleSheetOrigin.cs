namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Stylesheet type: "injected" for stylesheets injected via extension, "user-agent" for user-agent stylesheets, "inspector" for stylesheets created by the inspector (i.e. those holding the "via inspector" rules), "regular" for regular stylesheets.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StyleSheetOrigin
    {
    
        [EnumMember(Value = "injected")]
        Injected,
    
        [EnumMember(Value = "user-agent")]
        UserAgent,
    
        [EnumMember(Value = "inspector")]
        Inspector,
    
        [EnumMember(Value = "regular")]
        Regular,
    
    }
}