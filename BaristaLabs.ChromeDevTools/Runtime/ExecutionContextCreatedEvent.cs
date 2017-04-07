namespace BaristaLabs.ChromeDevTools.Runtime
{
    /// <summary>
    /// Issued when new execution context is created.
    /// </summary>
    public sealed class ExecutionContextCreatedEvent
    {
    
        
        /// <summary>
        /// A newly created execution contex.
        /// </summary>
        
        public ExecutionContextDescription Context
        {
            get;
            set;
        }
    
    }
}