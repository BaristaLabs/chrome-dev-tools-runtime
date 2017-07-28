namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Attributes which apply to widgets.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AXWidgetAttributes
    {
        [EnumMember(Value = "autocomplete")]
        Autocomplete,
        [EnumMember(Value = "haspopup")]
        Haspopup,
        [EnumMember(Value = "level")]
        Level,
        [EnumMember(Value = "multiselectable")]
        Multiselectable,
        [EnumMember(Value = "orientation")]
        Orientation,
        [EnumMember(Value = "multiline")]
        Multiline,
        [EnumMember(Value = "readonly")]
        Readonly,
        [EnumMember(Value = "required")]
        Required,
        [EnumMember(Value = "valuemin")]
        Valuemin,
        [EnumMember(Value = "valuemax")]
        Valuemax,
        [EnumMember(Value = "valuetext")]
        Valuetext,
    }
}