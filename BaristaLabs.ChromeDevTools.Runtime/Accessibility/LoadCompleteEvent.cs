namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// The loadComplete event mirrors the load complete event sent by the browser to assistive
    /// technology when the web page has finished loading.
    /// </summary>
    public sealed class LoadCompleteEvent : IEvent
    {
        /// <summary>
        /// New document root node.
        /// </summary>
        [JsonProperty("root")]
        public AXNode Root
        {
            get;
            set;
        }
    }
}