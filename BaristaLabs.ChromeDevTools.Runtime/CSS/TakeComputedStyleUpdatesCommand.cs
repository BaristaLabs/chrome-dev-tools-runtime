namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Polls the next batch of computed style updates.
    /// </summary>
    public sealed class TakeComputedStyleUpdatesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.takeComputedStyleUpdates";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class TakeComputedStyleUpdatesCommandResponse : ICommandResponse<TakeComputedStyleUpdatesCommand>
    {
        /// <summary>
        /// The list of node Ids that have their tracked computed styles updated
        ///</summary>
        [JsonProperty("nodeIds")]
        public long[] NodeIds
        {
            get;
            set;
        }
    }
}