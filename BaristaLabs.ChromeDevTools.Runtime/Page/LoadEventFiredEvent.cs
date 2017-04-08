namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// 
    /// </summary>
    [Event("Page.loadEventFired")]
    public sealed class LoadEventFiredEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the timestamp
        /// </summary>
        
        public double Timestamp
        {
            get;
            set;
        }
    
    }
}