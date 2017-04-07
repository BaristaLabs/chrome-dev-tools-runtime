namespace BaristaLabs.ChromeDevTools.Page
{
    /// <summary>
    /// Fired when a color has been picked.
    /// </summary>
    public sealed class ColorPickedEvent
    {
    
        
        /// <summary>
        /// RGBA of the picked color.
        /// </summary>
        
        public BaristaLabs.ChromeDevTools.DOM.RGBA Color
        {
            get;
            set;
        }
    
    }
}