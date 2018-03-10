namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Animation instance.
    /// </summary>
    public sealed class Animation
    {
        /// <summary>
        /// `Animation`'s id.
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// `Animation`'s name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// `Animation`'s internal paused state.
        ///</summary>
        [JsonProperty("pausedState")]
        public bool PausedState
        {
            get;
            set;
        }
        /// <summary>
        /// `Animation`'s play state.
        ///</summary>
        [JsonProperty("playState")]
        public string PlayState
        {
            get;
            set;
        }
        /// <summary>
        /// `Animation`'s playback rate.
        ///</summary>
        [JsonProperty("playbackRate")]
        public double PlaybackRate
        {
            get;
            set;
        }
        /// <summary>
        /// `Animation`'s start time.
        ///</summary>
        [JsonProperty("startTime")]
        public double StartTime
        {
            get;
            set;
        }
        /// <summary>
        /// `Animation`'s current time.
        ///</summary>
        [JsonProperty("currentTime")]
        public double CurrentTime
        {
            get;
            set;
        }
        /// <summary>
        /// Animation type of `Animation`.
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// `Animation`'s source animation node.
        ///</summary>
        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AnimationEffect Source
        {
            get;
            set;
        }
        /// <summary>
        /// A unique ID for `Animation` representing the sources that triggered this CSS
        /// animation/transition.
        ///</summary>
        [JsonProperty("cssId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CssId
        {
            get;
            set;
        }
    }
}