namespace BaristaLabs.ChromeDevTools.Debugger
{
    /// <summary>
    /// Fired when breakpoint is resolved to an actual script and location.
    /// </summary>
    public sealed class BreakpointResolvedEvent
    {
    
        
        /// <summary>
        /// Breakpoint unique identifier.
        /// </summary>
        
        public string BreakpointId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Actual breakpoint location.
        /// </summary>
        
        public Location Location
        {
            get;
            set;
        }
    
    }
}