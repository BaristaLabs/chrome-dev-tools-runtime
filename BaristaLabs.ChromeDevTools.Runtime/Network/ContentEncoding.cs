namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// List of content encodings supported by the backend.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentEncoding
    {
        [EnumMember(Value = "deflate")]
        Deflate,
        [EnumMember(Value = "gzip")]
        Gzip,
        [EnumMember(Value = "br")]
        Br,
    }
}