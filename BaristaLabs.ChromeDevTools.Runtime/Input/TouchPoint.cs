namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class TouchPoint
    {
    
        /// <summary>
        /// State of the touch point.
        ///</summary>
        [JsonProperty("state")]
        public string State
        {
            get;
            set;
        }
    
        /// <summary>
        /// X coordinate of the event relative to the main frame's viewport.
        ///</summary>
        [JsonProperty("x")]
        public long X
        {
            get;
            set;
        }
    
        /// <summary>
        /// Y coordinate of the event relative to the main frame's viewport. 0 refers to the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.
        ///</summary>
        [JsonProperty("y")]
        public long Y
        {
            get;
            set;
        }
    
        /// <summary>
        /// X radius of the touch area (default: 1).
        ///</summary>
        [JsonProperty("radiusX", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? RadiusX
        {
            get;
            set;
        }
    
        /// <summary>
        /// Y radius of the touch area (default: 1).
        ///</summary>
        [JsonProperty("radiusY", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? RadiusY
        {
            get;
            set;
        }
    
        /// <summary>
        /// Rotation angle (default: 0.0).
        ///</summary>
        [JsonProperty("rotationAngle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? RotationAngle
        {
            get;
            set;
        }
    
        /// <summary>
        /// Force (default: 1.0).
        ///</summary>
        [JsonProperty("force", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Force
        {
            get;
            set;
        }
    
        /// <summary>
        /// Identifier used to track touch sources between events, must be unique within an event.
        ///</summary>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Id
        {
            get;
            set;
        }
    
    }
}