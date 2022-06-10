namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// GatedAPIFeatures
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GatedAPIFeatures
    {
        [EnumMember(Value = "SharedArrayBuffers")]
        SharedArrayBuffers,
        [EnumMember(Value = "SharedArrayBuffersTransferAllowed")]
        SharedArrayBuffersTransferAllowed,
        [EnumMember(Value = "PerformanceMeasureMemory")]
        PerformanceMeasureMemory,
        [EnumMember(Value = "PerformanceProfile")]
        PerformanceProfile,
    }
}