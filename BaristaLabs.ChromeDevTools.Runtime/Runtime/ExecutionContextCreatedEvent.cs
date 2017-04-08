namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Issued when new execution context is created.
    /// </summary>
    [Event("Runtime.executionContextCreated")]
    public sealed class ExecutionContextCreatedEvent : IEvent
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