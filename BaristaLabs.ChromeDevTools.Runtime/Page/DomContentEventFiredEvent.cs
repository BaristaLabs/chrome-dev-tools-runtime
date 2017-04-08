namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// 
    /// </summary>
    [Event("Page.domContentEventFired")]
    public sealed class DomContentEventFiredEvent : IEvent
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