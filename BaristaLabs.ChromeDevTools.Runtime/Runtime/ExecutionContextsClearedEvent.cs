namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Issued when all executionContexts were cleared in browser
    /// </summary>
    [Event("Runtime.executionContextsCleared")]
    public sealed class ExecutionContextsClearedEvent : IEvent
    {
    
    }
}