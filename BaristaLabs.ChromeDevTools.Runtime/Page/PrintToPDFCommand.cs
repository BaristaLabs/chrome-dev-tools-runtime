namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Print page as PDF.
    /// </summary>
    public sealed class PrintToPDFCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.printToPDF";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Paper orientation. Defaults to false.
        /// </summary>
        [JsonProperty("landscape", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Landscape
        {
            get;
            set;
        }
        /// <summary>
        /// Display header and footer. Defaults to false.
        /// </summary>
        [JsonProperty("displayHeaderFooter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? DisplayHeaderFooter
        {
            get;
            set;
        }
        /// <summary>
        /// Print background graphics. Defaults to false.
        /// </summary>
        [JsonProperty("printBackground", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? PrintBackground
        {
            get;
            set;
        }
        /// <summary>
        /// Scale of the webpage rendering. Defaults to 1.
        /// </summary>
        [JsonProperty("scale", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Scale
        {
            get;
            set;
        }
        /// <summary>
        /// Paper width in inches. Defaults to 8.5 inches.
        /// </summary>
        [JsonProperty("paperWidth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? PaperWidth
        {
            get;
            set;
        }
        /// <summary>
        /// Paper height in inches. Defaults to 11 inches.
        /// </summary>
        [JsonProperty("paperHeight", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? PaperHeight
        {
            get;
            set;
        }
        /// <summary>
        /// Top margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        [JsonProperty("marginTop", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? MarginTop
        {
            get;
            set;
        }
        /// <summary>
        /// Bottom margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        [JsonProperty("marginBottom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? MarginBottom
        {
            get;
            set;
        }
        /// <summary>
        /// Left margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        [JsonProperty("marginLeft", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? MarginLeft
        {
            get;
            set;
        }
        /// <summary>
        /// Right margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        [JsonProperty("marginRight", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? MarginRight
        {
            get;
            set;
        }
        /// <summary>
        /// Paper ranges to print, e.g., '1-5, 8, 11-13'. Defaults to the empty string, which means print all pages.
        /// </summary>
        [JsonProperty("pageRanges", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PageRanges
        {
            get;
            set;
        }
    }

    public sealed class PrintToPDFCommandResponse : ICommandResponse<PrintToPDFCommand>
    {
        /// <summary>
        /// Base64-encoded pdf data.
        ///</summary>
        [JsonProperty("data")]
        public string Data
        {
            get;
            set;
        }
    }
}