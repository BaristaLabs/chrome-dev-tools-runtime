namespace BaristaLabs.ChromeDevTools.Target
{
    /// <summary>
    /// Issued when a target is destroyed.
    /// </summary>
    public sealed class TargetDestroyedEvent
    {
    
        
        /// <summary>
        /// Gets or sets the targetId
        /// </summary>
        
        public string TargetId
        {
            get;
            set;
        }
    
    }
}