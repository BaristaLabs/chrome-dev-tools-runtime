namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// States which apply to every AX node.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AXGlobalStates
    {
    
        [EnumMember(Value = "disabled")]
        Disabled,
    
        [EnumMember(Value = "hidden")]
        Hidden,
    
        [EnumMember(Value = "hiddenRoot")]
        HiddenRoot,
    
        [EnumMember(Value = "invalid")]
        Invalid,
    
        [EnumMember(Value = "keyshortcuts")]
        Keyshortcuts,
    
        [EnumMember(Value = "roledescription")]
        Roledescription,
    
    }
}