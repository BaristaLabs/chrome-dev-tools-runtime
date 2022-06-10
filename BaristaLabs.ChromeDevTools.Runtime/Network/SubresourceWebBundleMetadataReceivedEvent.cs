namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired once when parsing the .wbn file has succeeded.
    /// The event contains the information about the web bundle contents.
    /// </summary>
    public sealed class SubresourceWebBundleMetadataReceivedEvent : IEvent
    {
        /// <summary>
        /// Request identifier. Used to match this information to another event.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// A list of URLs of resources in the subresource Web Bundle.
        /// </summary>
        [JsonProperty("urls")]
        public string[] Urls
        {
            get;
            set;
        }
    }
}