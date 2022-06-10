namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Get Permissions Policy state on given frame.
    /// </summary>
    public sealed class GetPermissionsPolicyStateCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getPermissionsPolicyState";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the frameId
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    }

    public sealed class GetPermissionsPolicyStateCommandResponse : ICommandResponse<GetPermissionsPolicyStateCommand>
    {
        /// <summary>
        /// Gets or sets the states
        /// </summary>
        [JsonProperty("states")]
        public PermissionsPolicyFeatureState[] States
        {
            get;
            set;
        }
    }
}