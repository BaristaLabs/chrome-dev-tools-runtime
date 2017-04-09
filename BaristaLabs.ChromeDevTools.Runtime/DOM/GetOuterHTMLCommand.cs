namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns node's HTML markup.
    /// </summary>
    public sealed class GetOuterHTMLCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getOuterHTML";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to get markup for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }

    public sealed class GetOuterHTMLCommandResponse : ICommandResponse<GetOuterHTMLCommand>
    {
    
        
        /// <summary>
        /// Outer HTML markup.
        ///</summary>
        
        [JsonProperty("outerHTML")]
        public string OuterHTML
        {
            get;
            set;
        }
    
    }
}