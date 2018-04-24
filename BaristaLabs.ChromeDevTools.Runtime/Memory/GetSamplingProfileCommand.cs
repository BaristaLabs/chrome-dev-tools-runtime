namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Retrieve native memory allocations profile collected since last
    /// `startSampling` call.
    /// </summary>
    public sealed class GetSamplingProfileCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Memory.getSamplingProfile";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetSamplingProfileCommandResponse : ICommandResponse<GetSamplingProfileCommand>
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