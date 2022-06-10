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
        /// Deprecated metrics relating to the layout viewport. Is in device pixels. Use `cssLayoutViewport` instead.
        ///</summary>
        [JsonProperty("layoutViewport")]
        public LayoutViewport LayoutViewport
        {
            get;
            set;
        }
        /// <summary>
        /// Deprecated metrics relating to the visual viewport. Is in device pixels. Use `cssVisualViewport` instead.
        ///</summary>
        [JsonProperty("visualViewport")]
        public VisualViewport VisualViewport
        {
            get;
            set;
        }
        /// <summary>
        /// Deprecated size of scrollable area. Is in DP. Use `cssContentSize` instead.
        ///</summary>
        [JsonProperty("contentSize")]
        public DOM.Rect ContentSize
        {
            get;
            set;
        }
        /// <summary>
        /// Metrics relating to the layout viewport in CSS pixels.
        ///</summary>
        [JsonProperty("cssLayoutViewport")]
        public LayoutViewport CssLayoutViewport
        {
            get;
            set;
        }
        /// <summary>
        /// Metrics relating to the visual viewport in CSS pixels.
        ///</summary>
        [JsonProperty("cssVisualViewport")]
        public VisualViewport CssVisualViewport
        {
            get;
            set;
        }
        /// <summary>
        /// Size of scrollable area in CSS pixels.
        ///</summary>
        [JsonProperty("cssContentSize")]
        public DOM.Rect CssContentSize
        {
            get;
            set;
        }
    }
}