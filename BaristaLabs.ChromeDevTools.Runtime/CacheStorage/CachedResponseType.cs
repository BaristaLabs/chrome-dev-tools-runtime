namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// type of HTTP response cached
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CachedResponseType
    {
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "cors")]
        Cors,
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "opaqueResponse")]
        OpaqueResponse,
        [EnumMember(Value = "opaqueRedirect")]
        OpaqueRedirect,
    }
}