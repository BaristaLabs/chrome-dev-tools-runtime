namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired for failed bfcache history navigations if BackForwardCache feature is enabled. Do
    /// not assume any ordering with the Page.frameNavigated event. This event is fired only for
    /// main-frame history navigation where the document changes (non-same-document navigations),
    /// when bfcache navigation fails.
    /// </summary>
    public sealed class BackForwardCacheNotUsedEvent : IEvent
    {
        /// <summary>
        /// The loader id for the associated navgation.
        /// </summary>
        [JsonProperty("loaderId")]
        public string LoaderId
        {
            get;
            set;
        }
        /// <summary>
        /// The frame id of the associated frame.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Array of reasons why the page could not be cached. This must not be empty.
        /// </summary>
        [JsonProperty("notRestoredExplanations")]
        public BackForwardCacheNotRestoredExplanation[] NotRestoredExplanations
        {
            get;
            set;
        }
        /// <summary>
        /// Tree structure of reasons why the page could not be cached for each frame.
        /// </summary>
        [JsonProperty("notRestoredExplanationsTree", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BackForwardCacheNotRestoredExplanationTree NotRestoredExplanationsTree
        {
            get;
            set;
        }
    }
}