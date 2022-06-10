namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Ad advertising element inside an interest group.
    /// </summary>
    public sealed class InterestGroupAd
    {
        /// <summary>
        /// renderUrl
        ///</summary>
        [JsonProperty("renderUrl")]
        public string RenderUrl
        {
            get;
            set;
        }
        /// <summary>
        /// metadata
        ///</summary>
        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Metadata
        {
            get;
            set;
        }
    }
}