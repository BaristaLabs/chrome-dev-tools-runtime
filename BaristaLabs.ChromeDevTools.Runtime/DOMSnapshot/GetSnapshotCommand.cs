namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns a document snapshot, including the full DOM tree of the root node (including iframes, template contents, and imported documents) in a flattened array, as well as layout and white-listed computed style information for the nodes. Shadow DOM in the returned DOM tree is flattened. 
    /// </summary>
    public sealed class GetSnapshotCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOMSnapshot.getSnapshot";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whitelist of computed styles to return.
        /// </summary>
        [JsonProperty("computedStyleWhitelist")]
        public string[] ComputedStyleWhitelist
        {
            get;
            set;
        }
    }

    public sealed class GetSnapshotCommandResponse : ICommandResponse<GetSnapshotCommand>
    {
        /// <summary>
        /// The nodes in the DOM tree. The DOMNode at index 0 corresponds to the root document.
        ///</summary>
        [JsonProperty("domNodes")]
        public DOMNode[] DomNodes
        {
            get;
            set;
        }
        /// <summary>
        /// The nodes in the layout tree.
        ///</summary>
        [JsonProperty("layoutTreeNodes")]
        public LayoutTreeNode[] LayoutTreeNodes
        {
            get;
            set;
        }
        /// <summary>
        /// Whitelisted ComputedStyle properties for each node in the layout tree.
        ///</summary>
        [JsonProperty("computedStyles")]
        public ComputedStyle[] ComputedStyles
        {
            get;
            set;
        }
    }
}