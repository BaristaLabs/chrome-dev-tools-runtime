namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Animation instance.
    /// </summary>
    public sealed class Animation
    {
    
        /// <summary>
        /// <code>Animation</code>'s id.
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s internal paused state.
        ///</summary>
        [JsonProperty("pausedState")]
        public bool PausedState
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s play state.
        ///</summary>
        [JsonProperty("playState")]
        public string PlayState
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s playback rate.
        ///</summary>
        [JsonProperty("playbackRate")]
        public double PlaybackRate
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s start time.
        ///</summary>
        [JsonProperty("startTime")]
        public double StartTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s current time.
        ///</summary>
        [JsonProperty("currentTime")]
        public double CurrentTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>Animation</code>'s source animation node.
        ///</summary>
        [JsonProperty("source")]
        public AnimationEffect Source
        {
            get;
            set;
        }
    
        /// <summary>
        /// Animation type of <code>Animation</code>.
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// A unique ID for <code>Animation</code> representing the sources that triggered this CSS animation/transition.
        ///</summary>
        [JsonProperty("cssId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CssId
        {
            get;
            set;
        }
    
    }
}