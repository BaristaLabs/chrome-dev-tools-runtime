namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Terminate current or next JavaScript execution.
    /// Will cancel the termination when the outer-most script execution ends.
    /// </summary>
    public sealed class TerminateExecutionCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.terminateExecution";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class TerminateExecutionCommandResponse : ICommandResponse<TerminateExecutionCommand>
    {
    }
}