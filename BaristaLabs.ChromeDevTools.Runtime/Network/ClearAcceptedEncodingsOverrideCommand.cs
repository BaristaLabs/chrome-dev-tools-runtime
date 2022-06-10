namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears accepted encodings set by setAcceptedEncodings
    /// </summary>
    public sealed class ClearAcceptedEncodingsOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.clearAcceptedEncodingsOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class ClearAcceptedEncodingsOverrideCommandResponse : ICommandResponse<ClearAcceptedEncodingsOverrideCommand>
    {
    }
}