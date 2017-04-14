namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when a possible inspection target is created.
    /// </summary>
    public sealed class TargetCreatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the targetInfo
        /// </summary>
        
        [JsonProperty("targetInfo")]
        public TargetInfo TargetInfo
        {
            get;
            set;
        }
    
    }
}