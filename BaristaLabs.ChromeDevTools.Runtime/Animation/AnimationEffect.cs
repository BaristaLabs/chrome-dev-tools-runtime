namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// AnimationEffect instance
    /// </summary>
    public sealed class AnimationEffect
    {
        /// <summary>
        /// &lt;code&gt;AnimationEffect&lt;/code&gt;'s delay.
        ///</summary>
        [JsonProperty("delay")]
        public double Delay
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;AnimationEffect&lt;/code&gt;'s end delay.
        ///</summary>
        [JsonProperty("endDelay")]
        public double EndDelay
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;AnimationEffect&lt;/code&gt;'s iteration start.
        ///</summary>
        [JsonProperty("iterationStart")]
        public double IterationStart
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;AnimationEffect&lt;/code&gt;'s iterations.
        ///</summary>
        [JsonProperty("iterations")]
        public double Iterations
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;AnimationEffect&lt;/code&gt;'s iteration duration.
        ///</summary>
        [JsonProperty("duration")]
        public double Duration
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;AnimationEffect&lt;/code&gt;'s playback direction.
        ///</summary>
        [JsonProperty("direction")]
        public string Direction
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;AnimationEffect&lt;/code&gt;'s fill mode.
        ///</summary>
        [JsonProperty("fill")]
        public string Fill
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;AnimationEffect&lt;/code&gt;'s target node.
        ///</summary>
        [JsonProperty("backendNodeId")]
        public long BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;AnimationEffect&lt;/code&gt;'s keyframes.
        ///</summary>
        [JsonProperty("keyframesRule", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public KeyframesRule KeyframesRule
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;AnimationEffect&lt;/code&gt;'s timing function.
        ///</summary>
        [JsonProperty("easing")]
        public string Easing
        {
            get;
            set;
        }
    }
}