namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is &lt;code&gt;none&lt;/code&gt;.
    /// </summary>
    public sealed class SetPauseOnExceptionsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.setPauseOnExceptions";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Pause on exceptions mode.
        /// </summary>
        [JsonProperty("state")]
        public string State
        {
            get;
            set;
        }
    }

    public sealed class SetPauseOnExceptionsCommandResponse : ICommandResponse<SetPauseOnExceptionsCommand>
    {
    }
}