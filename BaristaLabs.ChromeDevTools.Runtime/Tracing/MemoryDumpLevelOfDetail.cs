namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details exposed when memory request explicitly declared.
    /// Keep consistent with memory_dump_request_args.h and
    /// memory_instrumentation.mojom
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MemoryDumpLevelOfDetail
    {
        [EnumMember(Value = "background")]
        Background,
        [EnumMember(Value = "light")]
        Light,
        [EnumMember(Value = "detailed")]
        Detailed,
    }
}