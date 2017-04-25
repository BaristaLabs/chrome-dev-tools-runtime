namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the computed style for a DOM node identified by &lt;code&gt;nodeId&lt;/code&gt;.
    /// </summary>
    public sealed class GetComputedStyleForNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getComputedStyleForNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the nodeId
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }

    public sealed class GetComputedStyleForNodeCommandResponse : ICommandResponse<GetComputedStyleForNodeCommand>
    {
        /// <summary>
        /// Computed style for the specified DOM node.
        ///</summary>
        [JsonProperty("computedStyle")]
        public CSSComputedStyleProperty[] ComputedStyle
        {
            get;
            set;
        }
    }
}