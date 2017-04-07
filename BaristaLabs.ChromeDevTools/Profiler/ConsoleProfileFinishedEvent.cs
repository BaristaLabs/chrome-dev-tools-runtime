namespace BaristaLabs.ChromeDevTools.Profiler
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ConsoleProfileFinishedEvent
    {
    
        
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        
        public string Id
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Location of console.profileEnd().
        /// </summary>
        
        public BaristaLabs.ChromeDevTools.Debugger.Location Location
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the profile
        /// </summary>
        
        public Profile Profile
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Profile title passed as an argument to console.profile().
        /// </summary>
        
        public string Title
        {
            get;
            set;
        }
    
    }
}