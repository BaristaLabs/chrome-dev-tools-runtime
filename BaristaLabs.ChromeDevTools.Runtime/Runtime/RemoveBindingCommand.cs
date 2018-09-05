namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// This method does not remove binding function from global object but
    /// unsubscribes current runtime agent from Runtime.bindingCalled notifications.
    /// </summary>
    public sealed class RemoveBindingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.removeBinding";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    }

    public sealed class RemoveBindingCommandResponse : ICommandResponse<RemoveBindingCommand>
    {
    }
}