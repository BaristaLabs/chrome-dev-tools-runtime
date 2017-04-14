namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Event for each animation that has been created.
    /// </summary>
    public sealed class AnimationCreatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Id of the animation that was created.
        /// </summary>
        
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
    
    }
}