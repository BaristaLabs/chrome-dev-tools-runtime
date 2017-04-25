namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of possible property sources.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AXValueSourceType
    {
        [EnumMember(Value = "attribute")]
        Attribute,
        [EnumMember(Value = "implicit")]
        Implicit,
        [EnumMember(Value = "style")]
        Style,
        [EnumMember(Value = "contents")]
        Contents,
        [EnumMember(Value = "placeholder")]
        Placeholder,
        [EnumMember(Value = "relatedElement")]
        RelatedElement,
    }
}