namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class AXProperty
    {
        /// <summary>
        /// The name of this property.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// The value of this property.
        ///</summary>
        [JsonProperty("value")]
        public AXValue Value
        {
            get;
            set;
        }
    }
}