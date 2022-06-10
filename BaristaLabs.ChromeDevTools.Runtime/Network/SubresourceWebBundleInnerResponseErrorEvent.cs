namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when request for resources within a .wbn file failed.
    /// </summary>
    public sealed class SubresourceWebBundleInnerResponseErrorEvent : IEvent
    {
        /// <summary>
        /// Request identifier of the subresource request
        /// </summary>
        [JsonProperty("innerRequestId")]
        public string InnerRequestId
        {
            get;
            set;
        }
        /// <summary>
        /// URL of the subresource resource.
        /// </summary>
        [JsonProperty("innerRequestURL")]
        public string InnerRequestURL
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
        /// <summary>
        /// Bundle request identifier. Used to match this information to another event.
        /// This made be absent in case when the instrumentation was enabled only
        /// after webbundle was parsed.
        /// </summary>
        [JsonProperty("bundleRequestId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BundleRequestId
        {
            get;
            set;
        }
    }
}