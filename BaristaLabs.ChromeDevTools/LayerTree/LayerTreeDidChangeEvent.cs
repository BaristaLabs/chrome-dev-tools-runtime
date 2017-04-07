namespace BaristaLabs.ChromeDevTools.LayerTree
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class LayerTreeDidChangeEvent
    {
    
        
        /// <summary>
        /// Layer tree, absent if not in the comspositing mode.
        /// </summary>
        
        public Layer[] Layers
        {
            get;
            set;
        }
    
    }
}