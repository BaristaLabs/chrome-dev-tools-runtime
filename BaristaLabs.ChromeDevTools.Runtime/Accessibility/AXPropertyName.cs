namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Values of AXProperty name:
    /// - from 'busy' to 'roledescription': states which apply to every AX node
    /// - from 'live' to 'root': attributes which apply to nodes in live regions
    /// - from 'autocomplete' to 'valuetext': attributes which apply to widgets
    /// - from 'checked' to 'selected': states which apply to widgets
    /// - from 'activedescendant' to 'owns' - relationships between elements other than parent/child/sibling.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AXPropertyName
    {
        [EnumMember(Value = "busy")]
        Busy,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "editable")]
        Editable,
        [EnumMember(Value = "focusable")]
        Focusable,
        [EnumMember(Value = "focused")]
        Focused,
        [EnumMember(Value = "hidden")]
        Hidden,
        [EnumMember(Value = "hiddenRoot")]
        HiddenRoot,
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "keyshortcuts")]
        Keyshortcuts,
        [EnumMember(Value = "settable")]
        Settable,
        [EnumMember(Value = "roledescription")]
        Roledescription,
        [EnumMember(Value = "live")]
        Live,
        [EnumMember(Value = "atomic")]
        Atomic,
        [EnumMember(Value = "relevant")]
        Relevant,
        [EnumMember(Value = "root")]
        Root,
        [EnumMember(Value = "autocomplete")]
        Autocomplete,
        [EnumMember(Value = "hasPopup")]
        HasPopup,
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