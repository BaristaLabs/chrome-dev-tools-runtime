namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Gets details for a named interest group.
    /// </summary>
    public sealed class GetInterestGroupDetailsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.getInterestGroupDetails";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the ownerOrigin
        /// </summary>
        [JsonProperty("ownerOrigin")]
        public string OwnerOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    }

    public sealed class GetInterestGroupDetailsCommandResponse : ICommandResponse<GetInterestGroupDetailsCommand>
    {
        /// <summary>
        /// Gets or sets the details
        /// </summary>
        [JsonProperty("details")]
        public InterestGroupDetails Details
        {
            get;
            set;
        }
    }
}