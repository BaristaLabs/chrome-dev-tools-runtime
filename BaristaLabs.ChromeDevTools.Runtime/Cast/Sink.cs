namespace BaristaLabs.ChromeDevTools.Runtime.Cast
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sink
    /// </summary>
    public sealed class Sink
    {
        /// <summary>
        /// name
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// id
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// Text describing the current session. Present only if there is an active
        /// session on the sink.
        ///</summary>
        [JsonProperty("session", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Session
        {
            get;
            set;
        }
    }
}