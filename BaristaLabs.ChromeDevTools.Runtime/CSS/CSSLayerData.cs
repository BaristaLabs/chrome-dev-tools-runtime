namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS Layer data.
    /// </summary>
    public sealed class CSSLayerData
    {
        /// <summary>
        /// Layer name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Direct sub-layers
        ///</summary>
        [JsonProperty("subLayers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSLayerData[] SubLayers
        {
            get;
            set;
        }
        /// <summary>
        /// Layer order. The order determines the order of the layer in the cascade order.
        /// A higher number has higher priority in the cascade order.
        ///</summary>
        [JsonProperty("order")]
        public double Order
        {
            get;
            set;
        }
    }
}