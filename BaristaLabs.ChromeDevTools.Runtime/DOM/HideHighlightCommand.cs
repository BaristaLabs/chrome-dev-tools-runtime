namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Hides any highlight.
    /// </summary>
    public sealed class HideHighlightCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.hideHighlight";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class HideHighlightCommandResponse : ICommandResponse<HideHighlightCommand>
    {
    }
}