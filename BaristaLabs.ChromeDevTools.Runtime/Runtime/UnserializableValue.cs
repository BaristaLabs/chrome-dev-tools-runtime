namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Primitive value which cannot be JSON-stringified.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnserializableValue
    {
    
        [EnumMember(Value = "Infinity")]
        Infinity,
    
        [EnumMember(Value = "NaN")]
        NaN,
    
        [EnumMember(Value = "-Infinity")]
        NegativeInfinity,
    
        [EnumMember(Value = "-0")]
        Negative0,
    
    }
}