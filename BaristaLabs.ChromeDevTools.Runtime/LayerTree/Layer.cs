namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// Information about a compositing layer.
    /// </summary>
    public sealed class Layer
    {
        /// <summary>
        /// The unique id for this layer.
        ///</summary>
        [JsonProperty("layerId")]
        public string LayerId
        {
            get;
            set;
        }
        /// <summary>
        /// The id of parent (not present for root).
        ///</summary>
        [JsonProperty("parentLayerId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ParentLayerId
        {
            get;
            set;
        }
        /// <summary>
        /// The backend id for the node associated with this layer.
        ///</summary>
        [JsonProperty("backendNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Offset from parent layer, X coordinate.
        ///</summary>
        [JsonProperty("offsetX")]
        public double OffsetX
        {
            get;
            set;
        }
        /// <summary>
        /// Offset from parent layer, Y coordinate.
        ///</summary>
        [JsonProperty("offsetY")]
        public double OffsetY
        {
            get;
            set;
        }
        /// <summary>
        /// Layer width.
        ///</summary>
        [JsonProperty("width")]
        public double Width
        {
            get;
            set;
        }
        /// <summary>
        /// Layer height.
        ///</summary>
        [JsonProperty("height")]
        public double Height
        {
            get;
            set;
        }
        /// <summary>
        /// Transformation matrix for layer, default is identity matrix
        ///</summary>
        [JsonProperty("transform", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double[] Transform
        {
            get;
            set;
        }
        /// <summary>
        /// Transform anchor point X, absent if no transform specified
        ///</summary>
        [JsonProperty("anchorX", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? AnchorX
        {
            get;
            set;
        }
        /// <summary>
        /// Transform anchor point Y, absent if no transform specified
        ///</summary>
        [JsonProperty("anchorY", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? AnchorY
        {
            get;
            set;
        }
        /// <summary>
        /// Transform anchor point Z, absent if no transform specified
        ///</summary>
        [JsonProperty("anchorZ", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? AnchorZ
        {
            get;
            set;
        }
        /// <summary>
        /// Indicates how many time this layer has painted.
        ///</summary>
        [JsonProperty("paintCount")]
        public long PaintCount
        {
            get;
            set;
        }
        /// <summary>
        /// Indicates whether this layer hosts any content, rather than being used for transform/scrolling purposes only.
        ///</summary>
        [JsonProperty("drawsContent")]
        public bool DrawsContent
        {
            get;
            set;
        }
        /// <summary>
        /// Set if layer is not visible.
        ///</summary>
        [JsonProperty("invisible", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Invisible
        {
            get;
            set;
        }
        /// <summary>
        /// Rectangles scrolling on main thread only.
        ///</summary>
        [JsonProperty("scrollRects", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ScrollRect[] ScrollRects
        {
            get;
            set;
        }
    }
}