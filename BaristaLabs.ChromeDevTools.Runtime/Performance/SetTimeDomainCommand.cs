namespace BaristaLabs.ChromeDevTools.Runtime.Performance
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets time domain to use for collecting and reporting duration metrics.
    /// Note that this must be called before enabling metrics collection. Calling
    /// this method while metrics collection is enabled returns an error.
    /// </summary>
    public sealed class SetTimeDomainCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Performance.setTimeDomain";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Time domain
        /// </summary>
        [JsonProperty("timeDomain")]
        public string TimeDomain
        {
            get;
            set;
        }
    }

    public sealed class SetTimeDomainCommandResponse : ICommandResponse<SetTimeDomainCommand>
    {
    }
}