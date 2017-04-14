namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when detached from target for any reason (including <code>detachFromTarget</code> command).
    /// </summary>
    public sealed class DetachedFromTargetEvent : IEvent
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