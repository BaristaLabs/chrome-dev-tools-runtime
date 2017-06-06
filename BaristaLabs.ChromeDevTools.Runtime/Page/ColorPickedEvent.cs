namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when a color has been picked.
    /// </summary>
    public sealed class ColorPickedEvent : IEvent
    {
    
        
        /// <summary>
        /// RGBA of the picked color.
        /// </summary>
        
        [JsonProperty("color")]
        public DOM.RGBA Color
        {
            get;
            set;
        }
    
    }
}