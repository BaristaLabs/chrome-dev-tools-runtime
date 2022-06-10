namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// If executionContextId is empty, adds binding with the given name on the
    /// global objects of all inspected contexts, including those created later,
    /// bindings survive reloads.
    /// Binding function takes exactly one argument, this argument should be string,
    /// in case of any other input, function throws an exception.
    /// Each binding function call produces Runtime.bindingCalled notification.
    /// </summary>
    public sealed class AddBindingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.addBinding";
        
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
        /// <summary>
        /// If specified, the binding would only be exposed to the specified
        /// execution context. If omitted and `executionContextName` is not set,
        /// the binding is exposed to all execution contexts of the target.
        /// This parameter is mutually exclusive with `executionContextName`.
        /// Deprecated in favor of `executionContextName` due to an unclear use case
        /// and bugs in implementation (crbug.com/1169639). `executionContextId` will be
        /// removed in the future.
        /// </summary>
        [JsonProperty("executionContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ExecutionContextId
        {
            get;
            set;
        }
        /// <summary>
        /// If specified, the binding is exposed to the executionContext with
        /// matching name, even for contexts created after the binding is added.
        /// See also `ExecutionContext.name` and `worldName` parameter to
        /// `Page.addScriptToEvaluateOnNewDocument`.
        /// This parameter is mutually exclusive with `executionContextId`.
        /// </summary>
        [JsonProperty("executionContextName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExecutionContextName
        {
            get;
            set;
        }
    }

    public sealed class AddBindingCommandResponse : ICommandResponse<AddBindingCommand>
    {
    }
}