namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Relationships between elements other than parent/child/sibling.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AXRelationshipAttributes
    {
    
        [EnumMember(Value = "activedescendant")]
        Activedescendant,
    
        [EnumMember(Value = "controls")]
        Controls,
    
        [EnumMember(Value = "describedby")]
        Describedby,
    
        [EnumMember(Value = "details")]
        Details,
    
        [EnumMember(Value = "errormessage")]
        Errormessage,
    
        [EnumMember(Value = "flowto")]
        Flowto,
    
        [EnumMember(Value = "labelledby")]
        Labelledby,
    
        [EnumMember(Value = "owns")]
        Owns,
    
    }
}