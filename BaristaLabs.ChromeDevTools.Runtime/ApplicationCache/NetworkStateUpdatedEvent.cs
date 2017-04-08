namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    /// <summary>
    /// 
    /// </summary>
    [Event("ApplicationCache.networkStateUpdated")]
    public sealed class NetworkStateUpdatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the isNowOnline
        /// </summary>
        
        public bool IsNowOnline
        {
            get;
            set;
        }
    
    }
}