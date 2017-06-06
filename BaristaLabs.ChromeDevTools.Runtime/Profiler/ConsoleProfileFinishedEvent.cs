namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ConsoleProfileFinishedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Location of console.profileEnd().
        /// </summary>
        
        [JsonProperty("location")]
        public Debugger.Location Location
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the profile
        /// </summary>
        
        [JsonProperty("profile")]
        public Profile Profile
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Profile title passed as an argument to console.profile().
        /// </summary>
        
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title
        {
            get;
            set;
        }
    
    }
}