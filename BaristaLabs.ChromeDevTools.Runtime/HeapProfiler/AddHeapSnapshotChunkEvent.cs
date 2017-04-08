namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    /// <summary>
    /// 
    /// </summary>
    [Event("HeapProfiler.addHeapSnapshotChunk")]
    public sealed class AddHeapSnapshotChunkEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the chunk
        /// </summary>
        
        public string Chunk
        {
            get;
            set;
        }
    
    }
}