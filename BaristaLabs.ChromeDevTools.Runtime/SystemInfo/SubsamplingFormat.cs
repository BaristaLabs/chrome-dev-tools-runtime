namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// YUV subsampling type of the pixels of a given image.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubsamplingFormat
    {
        [EnumMember(Value = "yuv420")]
        Yuv420,
        [EnumMember(Value = "yuv422")]
        Yuv422,
        [EnumMember(Value = "yuv444")]
        Yuv444,
    }
}