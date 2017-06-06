namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class LayerPaintedEvent : IEvent
    {
    
        
        /// <summary>
        /// The id of the painted layer.
        /// </summary>
        
        [JsonProperty("layerId")]
        public string LayerId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Clip rectangle.
        /// </summary>
        
        [JsonProperty("clip")]
        public DOM.Rect Clip
        {
            get;
            set;
        }
    
    }
}