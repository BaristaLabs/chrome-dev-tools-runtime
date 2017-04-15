namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Unique frame identifier.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrameId
    {
    
    }
}