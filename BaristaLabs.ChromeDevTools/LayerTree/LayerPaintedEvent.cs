namespace BaristaLabs.ChromeDevTools.LayerTree
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class LayerPaintedEvent
    {
    
        
        /// <summary>
        /// The id of the painted layer.
        /// </summary>
        
        public string LayerId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Clip rectangle.
        /// </summary>
        
        public BaristaLabs.ChromeDevTools.DOM.Rect Clip
        {
            get;
            set;
        }
    
    }
}