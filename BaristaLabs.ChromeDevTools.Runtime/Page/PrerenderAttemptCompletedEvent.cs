namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when a prerender attempt is completed.
    /// </summary>
    public sealed class PrerenderAttemptCompletedEvent : IEvent
    {
        /// <summary>
        /// The frame id of the frame initiating prerendering.
        /// </summary>
        [JsonProperty("initiatingFrameId")]
        public string InitiatingFrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the prerenderingUrl
        /// </summary>
        [JsonProperty("prerenderingUrl")]
        public string PrerenderingUrl
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the finalStatus
        /// </summary>
        [JsonProperty("finalStatus")]
        public PrerenderFinalStatus FinalStatus
        {
            get;
            set;
        }
    }
}