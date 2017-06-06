namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Retrieves a list of available targets.
    /// </summary>
    public sealed class GetTargetsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Target.getTargets";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetTargetsCommandResponse : ICommandResponse<GetTargetsCommand>
    {
    
        
        /// <summary>
        /// The list of targets.
        ///</summary>
        
        [JsonProperty("targetInfos")]
        public TargetInfo[] TargetInfos
        {
            get;
            set;
        }
    
    }
}