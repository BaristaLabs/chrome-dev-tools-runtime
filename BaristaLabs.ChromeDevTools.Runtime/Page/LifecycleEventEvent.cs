namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired for top level page lifecycle events such as navigation, load, paint, etc.
    /// </summary>
    public sealed class LifecycleEventEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
    }
}