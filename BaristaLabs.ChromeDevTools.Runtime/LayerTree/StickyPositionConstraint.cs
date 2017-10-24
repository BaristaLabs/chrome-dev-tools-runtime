namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sticky position constraints.
    /// </summary>
    public sealed class StickyPositionConstraint
    {
        /// <summary>
        /// Layout rectangle of the sticky element before being shifted
        ///</summary>
        [JsonProperty("stickyBoxRect")]
        public DOM.Rect StickyBoxRect
        {
            get;
            set;
        }
        /// <summary>
        /// Layout rectangle of the containing block of the sticky element
        ///</summary>
        [JsonProperty("containingBlockRect")]
        public DOM.Rect ContainingBlockRect
        {
            get;
            set;
        }
        /// <summary>
        /// The nearest sticky layer that shifts the sticky box
        ///</summary>
        [JsonProperty("nearestLayerShiftingStickyBox", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NearestLayerShiftingStickyBox
        {
            get;
            set;
        }
        /// <summary>
        /// The nearest sticky layer that shifts the containing block
        ///</summary>
        [JsonProperty("nearestLayerShiftingContainingBlock", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NearestLayerShiftingContainingBlock
        {
            get;
            set;
        }
    }
}