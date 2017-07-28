namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Highlights DOM node.
    /// </summary>
    public sealed class HighlightNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.highlightNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class HighlightNodeCommandResponse : ICommandResponse<HighlightNodeCommand>
    {
    }
}