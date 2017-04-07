namespace BaristaLabs.ChromeDevTools.CSS
{
    /// <summary>
    /// Fired whenever an active document stylesheet is added.
    /// </summary>
    public sealed class StyleSheetAddedEvent
    {
    
        
        /// <summary>
        /// Added stylesheet metainfo.
        /// </summary>
        
        public CSSStyleSheetHeader Header
        {
            get;
            set;
        }
    
    }
}