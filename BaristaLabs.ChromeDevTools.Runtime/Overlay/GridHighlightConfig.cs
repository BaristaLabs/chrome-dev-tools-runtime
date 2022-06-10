namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Configuration data for the highlighting of Grid elements.
    /// </summary>
    public sealed class GridHighlightConfig
    {
        /// <summary>
        /// Whether the extension lines from grid cells to the rulers should be shown (default: false).
        ///</summary>
        [JsonProperty("showGridExtensionLines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShowGridExtensionLines
        {
            get;
            set;
        }
        /// <summary>
        /// Show Positive line number labels (default: false).
        ///</summary>
        [JsonProperty("showPositiveLineNumbers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShowPositiveLineNumbers
        {
            get;
            set;
        }
        /// <summary>
        /// Show Negative line number labels (default: false).
        ///</summary>
        [JsonProperty("showNegativeLineNumbers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShowNegativeLineNumbers
        {
            get;
            set;
        }
        /// <summary>
        /// Show area name labels (default: false).
        ///</summary>
        [JsonProperty("showAreaNames", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShowAreaNames
        {
            get;
            set;
        }
        /// <summary>
        /// Show line name labels (default: false).
        ///</summary>
        [JsonProperty("showLineNames", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShowLineNames
        {
            get;
            set;
        }
        /// <summary>
        /// Show track size labels (default: false).
        ///</summary>
        [JsonProperty("showTrackSizes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShowTrackSizes
        {
            get;
            set;
        }
        /// <summary>
        /// The grid container border highlight color (default: transparent).
        ///</summary>
        [JsonProperty("gridBorderColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA GridBorderColor
        {
            get;
            set;
        }
        /// <summary>
        /// The cell border color (default: transparent). Deprecated, please use rowLineColor and columnLineColor instead.
        ///</summary>
        [JsonProperty("cellBorderColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA CellBorderColor
        {
            get;
            set;
        }
        /// <summary>
        /// The row line color (default: transparent).
        ///</summary>
        [JsonProperty("rowLineColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA RowLineColor
        {
            get;
            set;
        }
        /// <summary>
        /// The column line color (default: transparent).
        ///</summary>
        [JsonProperty("columnLineColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA ColumnLineColor
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the grid border is dashed (default: false).
        ///</summary>
        [JsonProperty("gridBorderDash", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? GridBorderDash
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the cell border is dashed (default: false). Deprecated, please us rowLineDash and columnLineDash instead.
        ///</summary>
        [JsonProperty("cellBorderDash", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CellBorderDash
        {
            get;
            set;
        }
        /// <summary>
        /// Whether row lines are dashed (default: false).
        ///</summary>
        [JsonProperty("rowLineDash", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? RowLineDash
        {
            get;
            set;
        }
        /// <summary>
        /// Whether column lines are dashed (default: false).
        ///</summary>
        [JsonProperty("columnLineDash", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ColumnLineDash
        {
            get;
            set;
        }
        /// <summary>
        /// The row gap highlight fill color (default: transparent).
        ///</summary>
        [JsonProperty("rowGapColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA RowGapColor
        {
            get;
            set;
        }
        /// <summary>
        /// The row gap hatching fill color (default: transparent).
        ///</summary>
        [JsonProperty("rowHatchColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA RowHatchColor
        {
            get;
            set;
        }
        /// <summary>
        /// The column gap highlight fill color (default: transparent).
        ///</summary>
        [JsonProperty("columnGapColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA ColumnGapColor
        {
            get;
            set;
        }
        /// <summary>
        /// The column gap hatching fill color (default: transparent).
        ///</summary>
        [JsonProperty("columnHatchColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA ColumnHatchColor
        {
            get;
            set;
        }
        /// <summary>
        /// The named grid areas border color (Default: transparent).
        ///</summary>
        [JsonProperty("areaBorderColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA AreaBorderColor
        {
            get;
            set;
        }
        /// <summary>
        /// The grid container background color (Default: transparent).
        ///</summary>
        [JsonProperty("gridBackgroundColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.RGBA GridBackgroundColor
        {
            get;
            set;
        }
    }
}