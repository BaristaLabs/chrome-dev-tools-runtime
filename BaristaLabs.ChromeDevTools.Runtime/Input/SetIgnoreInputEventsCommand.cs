namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// Ignores input events (useful while auditing page).
    /// </summary>
    public sealed class SetIgnoreInputEventsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Input.setIgnoreInputEvents";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Ignores input events processing when set to true.
        /// </summary>
        [JsonProperty("ignore")]
        public bool Ignore
        {
            get;
            set;
        }
    }

    public sealed class SetIgnoreInputEventsCommandResponse : ICommandResponse<SetIgnoreInputEventsCommand>
    {
    }
}