namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Tries to close page, running its beforeunload hooks, if any.
    /// </summary>
    public sealed class CloseCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.close";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class CloseCommandResponse : ICommandResponse<CloseCommand>
    {
    }
}