namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Forces compilation cache to be generated for every subresource script.
    /// </summary>
    public sealed class SetProduceCompilationCacheCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setProduceCompilationCache";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetProduceCompilationCacheCommandResponse : ICommandResponse<SetProduceCompilationCacheCommand>
    {
    }
}