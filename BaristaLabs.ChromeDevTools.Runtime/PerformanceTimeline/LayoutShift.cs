namespace BaristaLabs.ChromeDevTools.Runtime.PerformanceTimeline
{
    using Newtonsoft.Json;

    /// <summary>
    /// See https://wicg.github.io/layout-instability/#sec-layout-shift and layout_shift.idl
    /// </summary>
    public sealed class LayoutShift
    {
        /// <summary>
        /// Score increment produced by this event.
        ///</summary>
        [JsonProperty("value")]
        public double Value
        {
            get;
            set;
        }
        /// <summary>
        /// hadRecentInput
        ///</summary>
        [JsonProperty("hadRecentInput")]
        public bool HadRecentInput
        {
            get;
            set;
        }
        /// <summary>
        /// lastInputTime
        ///</summary>
        [JsonProperty("lastInputTime")]
        public double LastInputTime
        {
            get;
            set;
        }
        /// <summary>
        /// sources
        ///</summary>
        [JsonProperty("sources")]
        public LayoutShiftAttribution[] Sources
        {
            get;
            set;
        }
    }
}