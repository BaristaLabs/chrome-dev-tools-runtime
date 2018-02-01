namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// AnimationEffect instance
    /// </summary>
    public sealed class AnimationEffect
    {
        /// <summary>
        /// `AnimationEffect`'s delay.
        ///</summary>
        [JsonProperty("delay")]
        public double Delay
        {
            get;
            set;
        }
        /// <summary>
        /// `AnimationEffect`'s end delay.
        ///</summary>
        [JsonProperty("endDelay")]
        public double EndDelay
        {
            get;
            set;
        }
        /// <summary>
        /// `AnimationEffect`'s iteration start.
        ///</summary>
        [JsonProperty("iterationStart")]
        public double IterationStart
        {
            get;
            set;
        }
        /// <summary>
        /// `AnimationEffect`'s iterations.
        ///</summary>
        [JsonProperty("iterations")]
        public double Iterations
        {
            get;
            set;
        }
        /// <summary>
        /// `AnimationEffect`'s iteration duration.
        ///</summary>
        [JsonProperty("duration")]
        public double Duration
        {
            get;
            set;
        }
        /// <summary>
        /// `AnimationEffect`'s playback direction.
        ///</summary>
        [JsonProperty("direction")]
        public string Direction
        {
            get;
            set;
        }
        /// <summary>
        /// `AnimationEffect`'s fill mode.
        ///</summary>
        [JsonProperty("fill")]
        public string Fill
        {
            get;
            set;
        }
        /// <summary>
        /// `AnimationEffect`'s target node.
        ///</summary>
        [JsonProperty("backendNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// `AnimationEffect`'s keyframes.
        ///</summary>
        [JsonProperty("keyframesRule", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public KeyframesRule KeyframesRule
        {
            get;
            set;
        }
        /// <summary>
        /// `AnimationEffect`'s timing function.
        ///</summary>
        [JsonProperty("easing")]
        public string Easing
        {
            get;
            set;
        }
    }
}