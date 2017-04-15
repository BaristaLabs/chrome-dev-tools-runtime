namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Heap snapshot object id.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HeapSnapshotObjectId
    {
    
    }
}