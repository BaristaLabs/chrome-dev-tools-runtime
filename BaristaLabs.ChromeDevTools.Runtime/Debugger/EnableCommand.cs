namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables debugger for the given page. Clients should not assume that the debugging has been
    /// enabled until the result for this command is received.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The maximum size in bytes of collected scripts (not referenced by other heap objects)
        /// the debugger can hold. Puts no limit if parameter is omitted.
        /// </summary>
        [JsonProperty("maxScriptsCacheSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? MaxScriptsCacheSize
        {
            get;
            set;
        }
    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
        /// <summary>
        /// Unique identifier of the debugger.
        ///</summary>
        [JsonProperty("debuggerId")]
        public string DebuggerId
        {
            get;
            set;
        }
    }
}