namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// MouseButton
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MouseButton
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "middle")]
        Middle,
        [EnumMember(Value = "right")]
        Right,
        [EnumMember(Value = "back")]
        Back,
        [EnumMember(Value = "forward")]
        Forward,
    }
}