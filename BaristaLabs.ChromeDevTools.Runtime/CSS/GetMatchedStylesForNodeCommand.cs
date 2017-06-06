namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns requested styles for a DOM node identified by <code>nodeId</code>.
    /// </summary>
    public sealed class GetMatchedStylesForNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getMatchedStylesForNode";
        
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

    public sealed class GetMatchedStylesForNodeCommandResponse : ICommandResponse<GetMatchedStylesForNodeCommand>
    {
    
        
        /// <summary>
        /// Inline style for the specified DOM node.
        ///</summary>
        
        [JsonProperty("inlineStyle, DefaultValueHandling = DefaultValueHandling.Ignore")]
        public CSSStyle InlineStyle
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Attribute-defined element style (e.g. resulting from "width=20 height=100%").
        ///</summary>
        
        [JsonProperty("attributesStyle, DefaultValueHandling = DefaultValueHandling.Ignore")]
        public CSSStyle AttributesStyle
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// CSS rules matching this node, from all applicable stylesheets.
        ///</summary>
        
        [JsonProperty("matchedCSSRules, DefaultValueHandling = DefaultValueHandling.Ignore")]
        public RuleMatch[] MatchedCSSRules
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Pseudo style matches for this node.
        ///</summary>
        
        [JsonProperty("pseudoElements, DefaultValueHandling = DefaultValueHandling.Ignore")]
        public PseudoElementMatches[] PseudoElements
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// A chain of inherited styles (from the immediate node parent up to the DOM tree root).
        ///</summary>
        
        [JsonProperty("inherited, DefaultValueHandling = DefaultValueHandling.Ignore")]
        public InheritedStyleEntry[] Inherited
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// A list of CSS keyframed animations matching this node.
        ///</summary>
        
        [JsonProperty("cssKeyframesRules, DefaultValueHandling = DefaultValueHandling.Ignore")]
        public CSSKeyframesRule[] CssKeyframesRules
        {
            get;
            set;
        }
    
    }
}