namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates whether the frame is cross-origin isolated and why it is the case.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CrossOriginIsolatedContextType
    {
        [EnumMember(Value = "Isolated")]
        Isolated,
        [EnumMember(Value = "NotIsolated")]
        NotIsolated,
        [EnumMember(Value = "NotIsolatedFeatureDisabled")]
        NotIsolatedFeatureDisabled,
    }
}