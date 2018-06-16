namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// AXProperty
    /// </summary>
    public sealed class AXProperty
    {
        /// <summary>
        /// The name of this property.
        ///</summary>
        [JsonProperty("name")]
        public AXPropertyName Name
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