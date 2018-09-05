namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Get Chrome histograms.
    /// </summary>
    public sealed class GetHistogramsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.getHistograms";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Requested substring in name. Only histograms which have query as a
        /// substring in their name are extracted. An empty or absent query returns
        /// all histograms.
        /// </summary>
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Query
        {
            get;
            set;
        }
        /// <summary>
        /// If true, retrieve delta since last call.
        /// </summary>
        [JsonProperty("delta", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Delta
        {
            get;
            set;
        }
    }

    public sealed class GetHistogramsCommandResponse : ICommandResponse<GetHistogramsCommand>
    {
        /// <summary>
        /// Histograms.
        ///</summary>
        [JsonProperty("histograms")]
        public Histogram[] Histograms
        {
            get;
            set;
        }
    }
}