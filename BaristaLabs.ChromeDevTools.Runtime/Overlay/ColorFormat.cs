namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// ColorFormat
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ColorFormat
    {
        [EnumMember(Value = "rgb")]
        Rgb,
        [EnumMember(Value = "hsl")]
        Hsl,
        [EnumMember(Value = "hwb")]
        Hwb,
        [EnumMember(Value = "hex")]
        Hex,
    }
}