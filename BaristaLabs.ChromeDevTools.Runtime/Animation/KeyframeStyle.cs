namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Keyframe Style
    /// </summary>
    public sealed class KeyframeStyle
    {
        /// <summary>
        /// Keyframe's time offset.
        ///</summary>
        [JsonProperty("offset")]
        public string Offset
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