namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Resets navigation history for the current page.
    /// </summary>
    public sealed class ResetNavigationHistoryCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.resetNavigationHistory";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class ResetNavigationHistoryCommandResponse : ICommandResponse<ResetNavigationHistoryCommand>
    {
    }
}