namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Unique accessibility node identifier.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AXNodeId
    {
    
    }
}