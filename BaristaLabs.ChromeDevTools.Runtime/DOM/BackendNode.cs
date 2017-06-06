namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Backend node with a friendly name.
    /// </summary>
    public sealed class BackendNode
    {
    
        /// <summary>
        /// <code>Node</code>'s nodeType.
        ///</summary>
        [JsonProperty("nodeType")]
        public long NodeType
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Node</code>'s nodeName.
        ///</summary>
        [JsonProperty("nodeName")]
        public string NodeName
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("backendNodeId")]
        public long BackendNodeId
        {
            get;
            set;
        }
    
    }
}