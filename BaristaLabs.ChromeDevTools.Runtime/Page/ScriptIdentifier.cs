namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Unique script identifier.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScriptIdentifier
    {
    
    }
}