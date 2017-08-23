namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the styles defined inline (explicitly in the &quot;style&quot; attribute and implicitly, using DOM attributes) for a DOM node identified by &lt;code&gt;nodeId&lt;/code&gt;.
    /// </summary>
    public sealed class GetInlineStylesForNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getInlineStylesForNode";
        
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

    public sealed class GetInlineStylesForNodeCommandResponse : ICommandResponse<GetInlineStylesForNodeCommand>
    {
        /// <summary>
        /// Inline style for the specified DOM node.
        ///</summary>
        [JsonProperty("inlineStyle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSStyle InlineStyle
        {
            get;
            set;
        }
        /// <summary>
        /// Attribute-defined element style (e.g. resulting from &quot;width=20 height=100%&quot;).
        ///</summary>
        [JsonProperty("attributesStyle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSStyle AttributesStyle
        {
            get;
            set;
        }
    }
}