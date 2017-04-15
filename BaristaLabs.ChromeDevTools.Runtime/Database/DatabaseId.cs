namespace BaristaLabs.ChromeDevTools.Runtime.Database
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Unique identifier of Database object.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DatabaseId
    {
    
    }
}