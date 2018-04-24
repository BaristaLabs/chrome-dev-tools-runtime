namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Retrieve native memory allocations profile
    /// collected since renderer process startup.
    /// </summary>
    public sealed class GetAllTimeSamplingProfileCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Memory.getAllTimeSamplingProfile";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetAllTimeSamplingProfileCommandResponse : ICommandResponse<GetAllTimeSamplingProfileCommand>
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