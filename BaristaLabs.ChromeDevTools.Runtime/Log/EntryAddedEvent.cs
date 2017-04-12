namespace BaristaLabs.ChromeDevTools.Runtime.Log
{
    /// <summary>
    /// Issued when new message was logged.
    /// </summary>
    public sealed class EntryAddedEvent : IEvent
    {
    
        
        /// <summary>
        /// The entry.
        /// </summary>
        
        public LogEntry Entry
        {
            get;
            set;
        }
    
    }
}