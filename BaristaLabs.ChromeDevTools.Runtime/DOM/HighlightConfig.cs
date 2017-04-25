namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Configuration data for the highlighting of page elements.
    /// </summary>
    public sealed class HighlightConfig
    {
        /// <summary>
        /// Whether the node info tooltip should be shown (default: false).
        ///</summary>
        [JsonProperty("showInfo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShowInfo
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the rulers should be shown (default: false).
        ///</summary>
        [JsonProperty("showRulers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShowRulers
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the extension lines from node to the rulers should be shown (default: false).
        ///</summary>
        [JsonProperty("showExtensionLines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShowExtensionLines
        {
            get;
            set;
        }
        /// <summary>
        /// 
        ///</summary>
        [JsonProperty("displayAsMaterial", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? DisplayAsMaterial
        {
            get;
            set;
        }
        /// <summary>
        /// The content box highlight fill color (default: transparent).
        ///</summary>
        [JsonProperty("contentColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RGBA ContentColor
        {
            get;
            set;
        }
        /// <summary>
        /// The padding highlight fill color (default: transparent).
        ///</summary>
        [JsonProperty("paddingColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RGBA PaddingColor
        {
            get;
            set;
        }
        /// <summary>
        /// The border highlight fill color (default: transparent).
        ///</summary>
        [JsonProperty("borderColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RGBA BorderColor
        {
            get;
            set;
        }
        /// <summary>
        /// The margin highlight fill color (default: transparent).
        ///</summary>
        [JsonProperty("marginColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RGBA MarginColor
        {
            get;
            set;
        }
        /// <summary>
        /// The event target element highlight fill color (default: transparent).
        ///</summary>
        [JsonProperty("eventTargetColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RGBA EventTargetColor
        {
            get;
            set;
        }
        /// <summary>
        /// The shape outside fill color (default: transparent).
        ///</summary>
        [JsonProperty("shapeColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RGBA ShapeColor
        {
            get;
            set;
        }
        /// <summary>
        /// The shape margin fill color (default: transparent).
        ///</summary>
        [JsonProperty("shapeMarginColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RGBA ShapeMarginColor
        {
            get;
            set;
        }
        /// <summary>
        /// Selectors to highlight relevant nodes.
        ///</summary>
        [JsonProperty("selectorList", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SelectorList
        {
            get;
            set;
        }
    }
}