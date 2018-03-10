namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Compression type to use for traces returned via streams.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StreamCompression
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "gzip")]
        Gzip,
    }
}