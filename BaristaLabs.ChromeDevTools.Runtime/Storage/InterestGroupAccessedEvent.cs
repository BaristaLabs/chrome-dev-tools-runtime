namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// One of the interest groups was accessed by the associated page.
    /// </summary>
    public sealed class InterestGroupAccessedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the accessTime
        /// </summary>
        [JsonProperty("accessTime")]
        public double AccessTime
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the type
        /// </summary>
        [JsonProperty("type")]
        public InterestGroupAccessType Type
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the ownerOrigin
        /// </summary>
        [JsonProperty("ownerOrigin")]
        public string OwnerOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    }
}