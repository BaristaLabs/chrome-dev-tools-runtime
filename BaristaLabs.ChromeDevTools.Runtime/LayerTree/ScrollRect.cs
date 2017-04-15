namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// Rectangle where scrolling happens on the main thread.
    /// </summary>
    public sealed class ScrollRect
    {
    
        /// <summary>
        /// Rectangle itself.
        ///</summary>
        [JsonProperty("rect")]
        public DOM.Rect Rect
        {
            get;
            set;
        }
    
        /// <summary>
        /// Reason for rectangle to force scrolling on the main thread
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    
    }
}