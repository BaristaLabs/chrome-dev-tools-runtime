namespace BaristaLabs.ChromeDevTools.Runtime
{
    /// <summary>
    /// Issued when execution context is destroyed.
    /// </summary>
    public sealed class ExecutionContextDestroyedEvent
    {
    
        
        /// <summary>
        /// Id of the destroyed context
        /// </summary>
        
        public long ExecutionContextId
        {
            get;
            set;
        }
    
    }
}