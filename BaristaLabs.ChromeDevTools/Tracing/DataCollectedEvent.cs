namespace BaristaLabs.ChromeDevTools.Tracing
{
    /// <summary>
    /// Contains an bucket of collected trace events. When tracing is stopped collected events will be send as a sequence of dataCollected events followed by tracingComplete event.
    /// </summary>
    public sealed class DataCollectedEvent
    {
    
        
        /// <summary>
        /// Gets or sets the value
        /// </summary>
        
        public object[] Value
        {
            get;
            set;
        }
    
    }
}