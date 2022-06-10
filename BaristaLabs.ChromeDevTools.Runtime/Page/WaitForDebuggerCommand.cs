namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Pauses page execution. Can be resumed using generic Runtime.runIfWaitingForDebugger.
    /// </summary>
    public sealed class WaitForDebuggerCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.waitForDebugger";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class WaitForDebuggerCommandResponse : ICommandResponse<WaitForDebuggerCommand>
    {
    }
}