namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// This method sends a new XMLHttpRequest which is identical to the original one. The following parameters should be identical: method, url, async, request body, extra headers, withCredentials attribute, user, password.
    /// </summary>
    public sealed class ReplayXHRCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.replayXHR";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of XHR to replay.
        /// </summary>
        
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
    
    }

    public sealed class ReplayXHRCommandResponse : ICommandResponse<ReplayXHRCommand>
    {
    
    }
}