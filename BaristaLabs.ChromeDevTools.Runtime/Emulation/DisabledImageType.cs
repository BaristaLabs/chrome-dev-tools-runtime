namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of image types that can be disabled.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisabledImageType
    {
        [EnumMember(Value = "avif")]
        Avif,
        [EnumMember(Value = "jxl")]
        Jxl,
        [EnumMember(Value = "webp")]
        Webp,
    }
}