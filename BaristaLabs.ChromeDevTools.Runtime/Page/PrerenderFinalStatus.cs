namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// List of FinalStatus reasons for Prerender2.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrerenderFinalStatus
    {
        [EnumMember(Value = "Activated")]
        Activated,
    }
}