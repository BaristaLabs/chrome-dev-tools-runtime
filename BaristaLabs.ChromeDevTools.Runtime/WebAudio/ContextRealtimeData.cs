namespace BaristaLabs.ChromeDevTools.Runtime.WebAudio
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fields in AudioContext that change in real-time.
    /// </summary>
    public sealed class ContextRealtimeData
    {
        /// <summary>
        /// The current context time in second in BaseAudioContext.
        ///</summary>
        [JsonProperty("currentTime")]
        public double CurrentTime
        {
            get;
            set;
        }
        /// <summary>
        /// The time spent on rendering graph divided by render quantum duration,
        /// and multiplied by 100. 100 means the audio renderer reached the full
        /// capacity and glitch may occur.
        ///</summary>
        [JsonProperty("renderCapacity")]
        public double RenderCapacity
        {
            get;
            set;
        }
        /// <summary>
        /// A running mean of callback interval.
        ///</summary>
        [JsonProperty("callbackIntervalMean")]
        public double CallbackIntervalMean
        {
            get;
            set;
        }
        /// <summary>
        /// A running variance of callback interval.
        ///</summary>
        [JsonProperty("callbackIntervalVariance")]
        public double CallbackIntervalVariance
        {
            get;
            set;
        }
    }
}