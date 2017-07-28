namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Animation instance.
    /// </summary>
    public sealed class Animation
    {
        /// <summary>
        /// &lt;code&gt;Animation&lt;/code&gt;'s id.
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Animation&lt;/code&gt;'s name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Animation&lt;/code&gt;'s internal paused state.
        ///</summary>
        [JsonProperty("pausedState")]
        public bool PausedState
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Animation&lt;/code&gt;'s play state.
        ///</summary>
        [JsonProperty("playState")]
        public string PlayState
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Animation&lt;/code&gt;'s playback rate.
        ///</summary>
        [JsonProperty("playbackRate")]
        public double PlaybackRate
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Animation&lt;/code&gt;'s start time.
        ///</summary>
        [JsonProperty("startTime")]
        public double StartTime
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Animation&lt;/code&gt;'s current time.
        ///</summary>
        [JsonProperty("currentTime")]
        public double CurrentTime
        {
            get;
            set;
        }
        /// <summary>
        /// &lt;code&gt;Animation&lt;/code&gt;'s source animation node.
        ///</summary>
        [JsonProperty("source")]
        public AnimationEffect Source
        {
            get;
            set;
        }
        /// <summary>
        /// Animation type of &lt;code&gt;Animation&lt;/code&gt;.
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// A unique ID for &lt;code&gt;Animation&lt;/code&gt; representing the sources that triggered this CSS animation/transition.
        ///</summary>
        [JsonProperty("cssId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CssId
        {
            get;
            set;
        }
    }
}