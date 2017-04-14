namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// AnimationEffect instance
    /// </summary>
    public sealed class AnimationEffect
    {
    
        /// <summary>
        /// <code>AnimationEffect</code>'s delay.
        ///</summary>
        [JsonProperty("delay")]
        public double Delay
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s end delay.
        ///</summary>
        [JsonProperty("endDelay")]
        public double EndDelay
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s iteration start.
        ///</summary>
        [JsonProperty("iterationStart")]
        public double IterationStart
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s iterations.
        ///</summary>
        [JsonProperty("iterations")]
        public double Iterations
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s iteration duration.
        ///</summary>
        [JsonProperty("duration")]
        public double Duration
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s playback direction.
        ///</summary>
        [JsonProperty("direction")]
        public string Direction
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s fill mode.
        ///</summary>
        [JsonProperty("fill")]
        public string Fill
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s target node.
        ///</summary>
        [JsonProperty("backendNodeId")]
        public long BackendNodeId
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s keyframes.
        ///</summary>
        [JsonProperty("keyframesRule", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public KeyframesRule KeyframesRule
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>AnimationEffect</code>'s timing function.
        ///</summary>
        [JsonProperty("easing")]
        public string Easing
        {
            get;
            set;
        }
    
    }
}