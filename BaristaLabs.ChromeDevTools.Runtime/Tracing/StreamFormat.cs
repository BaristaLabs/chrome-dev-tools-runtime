namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Data format of a trace. Can be either the legacy JSON format or the
    /// protocol buffer format. Note that the JSON format will be deprecated soon.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StreamFormat
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "proto")]
        Proto,
    }
}