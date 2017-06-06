namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
    /// </summary>
    public sealed class GetLayoutMetricsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getLayoutMetrics";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetLayoutMetricsCommandResponse : ICommandResponse<GetLayoutMetricsCommand>
    {
    
        
        /// <summary>
        /// Metrics relating to the layout viewport.
        ///</summary>
        
        [JsonProperty("layoutViewport")]
        public LayoutViewport LayoutViewport
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Metrics relating to the visual viewport.
        ///</summary>
        
        [JsonProperty("visualViewport")]
        public VisualViewport VisualViewport
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Size of scrollable area.
        ///</summary>
        
        [JsonProperty("contentSize")]
        public DOM.Rect ContentSize
        {
            get;
            set;
        }
    
    }
}