namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Breakpoint identifier.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BreakpointId
    {
    
    }
}