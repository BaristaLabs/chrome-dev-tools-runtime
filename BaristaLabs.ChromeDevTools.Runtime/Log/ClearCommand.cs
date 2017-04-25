namespace BaristaLabs.ChromeDevTools.Runtime.Log
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears the log.
    /// </summary>
    public sealed class ClearCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Log.clear";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class ClearCommandResponse : ICommandResponse<ClearCommand>
    {
    }
}