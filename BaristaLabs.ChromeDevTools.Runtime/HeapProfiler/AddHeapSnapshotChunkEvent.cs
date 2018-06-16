namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// AddHeapSnapshotChunk
    /// </summary>
    public sealed class AddHeapSnapshotChunkEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the chunk
        /// </summary>
        [JsonProperty("chunk")]
        public string Chunk
        {
            get;
            set;
        }
    }
}