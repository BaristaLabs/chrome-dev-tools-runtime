namespace BaristaLabs.ChromeDevTools.Network
{
    /// <summary>
    /// Fired when resource loading priority is changed
    /// </summary>
    public sealed class ResourceChangedPriorityEvent
    {
    
        
        /// <summary>
        /// Request identifier.
        /// </summary>
        
        public string RequestId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// New priority
        /// </summary>
        
        public ResourcePriority NewPriority
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Timestamp.
        /// </summary>
        
        public double Timestamp
        {
            get;
            set;
        }
    
    }
}