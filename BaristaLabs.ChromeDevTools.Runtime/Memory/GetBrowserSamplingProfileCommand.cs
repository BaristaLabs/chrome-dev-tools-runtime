namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Retrieve native memory allocations profile
    /// collected since browser process startup.
    /// </summary>
    public sealed class GetBrowserSamplingProfileCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Memory.getBrowserSamplingProfile";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetBrowserSamplingProfileCommandResponse : ICommandResponse<GetBrowserSamplingProfileCommand>
    {
        /// <summary>
        /// Gets or sets the profile
        /// </summary>
        [JsonProperty("profile")]
        public SamplingProfile Profile
        {
            get;
            set;
        }
    }
}