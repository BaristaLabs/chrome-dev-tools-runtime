namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class LayerTreeDidChangeEvent : IEvent
    {
        /// <summary>
        /// Layer tree, absent if not in the comspositing mode.
        /// </summary>
        [JsonProperty("layers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Layer[] Layers
        {
            get;
            set;
        }
    }
}