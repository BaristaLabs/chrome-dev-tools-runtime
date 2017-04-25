namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height, window.innerWidth, window.innerHeight, and &quot;device-width&quot;/&quot;device-height&quot;-related CSS media query results).
    /// </summary>
    public sealed class SetDeviceMetricsOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setDeviceMetricsOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Overriding width value in pixels (minimum 0, maximum 10000000). 0 disables the override.
        /// </summary>
        [JsonProperty("width")]
        public long Width
        {
            get;
            set;
        }
        /// <summary>
        /// Overriding height value in pixels (minimum 0, maximum 10000000). 0 disables the override.
        /// </summary>
        [JsonProperty("height")]
        public long Height
        {
            get;
            set;
        }
        /// <summary>
        /// Overriding device scale factor value. 0 disables the override.
        /// </summary>
        [JsonProperty("deviceScaleFactor")]
        public double DeviceScaleFactor
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to emulate mobile device. This includes viewport meta tag, overlay scrollbars, text autosizing and more.
        /// </summary>
        [JsonProperty("mobile")]
        public bool Mobile
        {
            get;
            set;
        }
        /// <summary>
        /// Whether a view that exceeds the available browser window area should be scaled down to fit.
        /// </summary>
        [JsonProperty("fitWindow")]
        public bool FitWindow
        {
            get;
            set;
        }
        /// <summary>
        /// Scale to apply to resulting view image. Ignored in |fitWindow| mode.
        /// </summary>
        [JsonProperty("scale", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Scale
        {
            get;
            set;
        }
        /// <summary>
        /// X offset to shift resulting view image by. Ignored in |fitWindow| mode.
        /// </summary>
        [JsonProperty("offsetX", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? OffsetX
        {
            get;
            set;
        }
        /// <summary>
        /// Y offset to shift resulting view image by. Ignored in |fitWindow| mode.
        /// </summary>
        [JsonProperty("offsetY", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? OffsetY
        {
            get;
            set;
        }
        /// <summary>
        /// Overriding screen width value in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
        /// </summary>
        [JsonProperty("screenWidth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ScreenWidth
        {
            get;
            set;
        }
        /// <summary>
        /// Overriding screen height value in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
        /// </summary>
        [JsonProperty("screenHeight", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ScreenHeight
        {
            get;
            set;
        }
        /// <summary>
        /// Overriding view X position on screen in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
        /// </summary>
        [JsonProperty("positionX", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? PositionX
        {
            get;
            set;
        }
        /// <summary>
        /// Overriding view Y position on screen in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
        /// </summary>
        [JsonProperty("positionY", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? PositionY
        {
            get;
            set;
        }
        /// <summary>
        /// Screen orientation override.
        /// </summary>
        [JsonProperty("screenOrientation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Emulation.ScreenOrientation ScreenOrientation
        {
            get;
            set;
        }
    }

    public sealed class SetDeviceMetricsOverrideCommandResponse : ICommandResponse<SetDeviceMetricsOverrideCommand>
    {
    }
}