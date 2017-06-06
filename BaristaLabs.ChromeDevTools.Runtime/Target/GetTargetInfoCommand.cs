namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns information about a target.
    /// </summary>
    public sealed class GetTargetInfoCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Target.getTargetInfo";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the targetId
        /// </summary>
        
        [JsonProperty("targetId")]
        public string TargetId
        {
            get;
            set;
        }
    
    }

    public sealed class GetTargetInfoCommandResponse : ICommandResponse<GetTargetInfoCommand>
    {
    
        
        /// <summary>
        /// Gets or sets the targetInfo
        /// </summary>
        
        [JsonProperty("targetInfo")]
        public TargetInfo TargetInfo
        {
            get;
            set;
        }
    
    }
}