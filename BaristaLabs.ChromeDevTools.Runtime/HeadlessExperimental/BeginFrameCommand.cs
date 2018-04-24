namespace BaristaLabs.ChromeDevTools.Runtime.HeadlessExperimental
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sends a BeginFrame to the target and returns when the frame was completed. Optionally captures a
    /// screenshot from the resulting frame. Requires that the target was created with enabled
    /// BeginFrameControl. Designed for use with --run-all-compositor-stages-before-draw, see also
    /// https://goo.gl/3zHXhB for more background.
    /// </summary>
    public sealed class BeginFrameCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "HeadlessExperimental.beginFrame";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Timestamp of this BeginFrame (milliseconds since epoch). If not set, the current time will
        /// be used.
        /// </summary>
        [JsonProperty("frameTime", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? FrameTime
        {
            get;
            set;
        }
        /// <summary>
        /// Deadline of this BeginFrame (milliseconds since epoch). If not set, the deadline will be
        /// calculated from the frameTime and interval.
        /// </summary>
        [JsonProperty("deadline", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Deadline
        {
            get;
            set;
        }
        /// <summary>
        /// The interval between BeginFrames that is reported to the compositor, in milliseconds.
        /// Defaults to a 60 frames/second interval, i.e. about 16.666 milliseconds.
        /// </summary>
        [JsonProperty("interval", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Interval
        {
            get;
            set;
        }
        /// <summary>
        /// Whether updates should not be committed and drawn onto the display. False by default. If
        /// true, only side effects of the BeginFrame will be run, such as layout and animations, but
        /// any visual updates may not be visible on the display or in screenshots.
        /// </summary>
        [JsonProperty("noDisplayUpdates", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? NoDisplayUpdates
        {
            get;
            set;
        }
        /// <summary>
        /// If set, a screenshot of the frame will be captured and returned in the response. Otherwise,
        /// no screenshot will be captured. Note that capturing a screenshot can fail, for example,
        /// during renderer initialization. In such a case, no screenshot data will be returned.
        /// </summary>
        [JsonProperty("screenshot", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ScreenshotParams Screenshot
        {
            get;
            set;
        }
    }

    public sealed class BeginFrameCommandResponse : ICommandResponse<BeginFrameCommand>
    {
        /// <summary>
        /// Whether the BeginFrame resulted in damage and, thus, a new frame was committed to the
        /// display. Reported for diagnostic uses, may be removed in the future.
        ///</summary>
        [JsonProperty("hasDamage")]
        public bool HasDamage
        {
            get;
            set;
        }
        /// <summary>
        /// Base64-encoded image data of the screenshot, if one was requested and successfully taken.
        ///</summary>
        [JsonProperty("screenshotData", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ScreenshotData
        {
            get;
            set;
        }
    }
}