namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired once when parsing the .wbn file has failed.
    /// </summary>
    public sealed class SubresourceWebBundleMetadataErrorEvent : IEvent
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
        /// Error message
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage
        {
            get;
            set;
        }
    }
}