namespace BaristaLabs.ChromeDevTools.Network
{
    /// <summary>
    /// Fired if request ended up loading from cache.
    /// </summary>
    public sealed class RequestServedFromCacheEvent
    {
    
        
        /// <summary>
        /// Request identifier.
        /// </summary>
        
        public string RequestId
        {
            get;
            set;
        }
    
    }
}