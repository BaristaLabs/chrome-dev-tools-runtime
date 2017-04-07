namespace BaristaLabs.ChromeDevTools.Target
{
    /// <summary>
    /// Issued when a possible inspection target is created.
    /// </summary>
    public sealed class TargetCreatedEvent
    {
    
        
        /// <summary>
        /// Gets or sets the targetInfo
        /// </summary>
        
        public TargetInfo TargetInfo
        {
            get;
            set;
        }
    
    }
}