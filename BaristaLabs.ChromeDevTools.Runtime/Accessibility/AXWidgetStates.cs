namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// States which apply to widgets.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AXWidgetStates
    {
        [EnumMember(Value = "checked")]
        Checked,
        [EnumMember(Value = "expanded")]
        Expanded,
        [EnumMember(Value = "modal")]
        Modal,
        [EnumMember(Value = "pressed")]
        Pressed,
        [EnumMember(Value = "selected")]
        Selected,
    }
}