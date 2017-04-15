namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sent when new profile recodring is started using console.profile() call.
    /// </summary>
    public sealed class ConsoleProfileStartedEvent : IEvent
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
        /// Location of console.profile().
        /// </summary>
        
        [JsonProperty("location")]
        public Debugger.Location Location
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