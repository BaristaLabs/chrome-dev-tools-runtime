namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class GetBackgroundColorsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getBackgroundColors";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Id of the node to get background colors for.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }

    public sealed class GetBackgroundColorsCommandResponse : ICommandResponse<GetBackgroundColorsCommand>
    {
        /// <summary>
        /// The range of background colors behind this element, if it contains any visible text. If no visible text is present, this will be undefined. In the case of a flat background color, this will consist of simply that color. In the case of a gradient, this will consist of each of the color stops. For anything more complicated, this will be an empty array. Images will be ignored (as if the image had failed to load).
        ///</summary>
        [JsonProperty("backgroundColors", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] BackgroundColors
        {
            get;
            set;
        }
        /// <summary>
        /// The computed font size for this node, as a CSS computed value string (e.g. '12px').
        ///</summary>
        [JsonProperty("computedFontSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ComputedFontSize
        {
            get;
            set;
        }
        /// <summary>
        /// The computed font weight for this node, as a CSS computed value string (e.g. 'normal' or '100').
        ///</summary>
        [JsonProperty("computedFontWeight", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ComputedFontWeight
        {
            get;
            set;
        }
        /// <summary>
        /// The computed font size for the document body, as a computed CSS value string (e.g. '16px').
        ///</summary>
        [JsonProperty("computedBodyFontSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ComputedBodyFontSize
        {
            get;
            set;
        }
    }
}