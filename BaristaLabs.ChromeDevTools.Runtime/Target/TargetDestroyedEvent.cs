namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when a target is destroyed.
    /// </summary>
    public sealed class TargetDestroyedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the targetId
        /// </summary>
        
        [JsonProperty("targetId")]
        public string TargetId
        {
            get;
            set;
        }
    
    }
}