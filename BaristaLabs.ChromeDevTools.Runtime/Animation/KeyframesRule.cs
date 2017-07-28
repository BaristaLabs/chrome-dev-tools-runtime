namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Keyframes Rule
    /// </summary>
    public sealed class KeyframesRule
    {
        /// <summary>
        /// CSS keyframed animation's name.
        ///</summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// List of animation keyframes.
        ///</summary>
        [JsonProperty("keyframes")]
        public KeyframeStyle[] Keyframes
        {
            get;
            set;
        }
    }
}