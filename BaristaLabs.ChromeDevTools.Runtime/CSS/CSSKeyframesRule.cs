namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS keyframes rule representation.
    /// </summary>
    public sealed class CSSKeyframesRule
    {
        /// <summary>
        /// Animation name.
        ///</summary>
        [JsonProperty("animationName")]
        public Value AnimationName
        {
            get;
            set;
        }
        /// <summary>
        /// List of keyframes.
        ///</summary>
        [JsonProperty("keyframes")]
        public CSSKeyframeRule[] Keyframes
        {
            get;
            set;
        }
    }
}