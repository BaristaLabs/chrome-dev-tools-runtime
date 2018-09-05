namespace BaristaLabs.ChromeDevTools.Runtime.DOMSnapshot
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details of post layout rendered text positions. The exact layout should not be regarded as
    /// stable and may change between versions.
    /// </summary>
    public sealed class TextBoxSnapshot
    {
        /// <summary>
        /// Intex of th elayout tree node that owns this box collection.
        ///</summary>
        [JsonProperty("layoutIndex")]
        public long[] LayoutIndex
        {
            get;
            set;
        }
        /// <summary>
        /// The absolute position bounding box.
        ///</summary>
        [JsonProperty("bounds")]
        public double[][] Bounds
        {
            get;
            set;
        }
        /// <summary>
        /// The starting index in characters, for this post layout textbox substring. Characters that
        /// would be represented as a surrogate pair in UTF-16 have length 2.
        ///</summary>
        [JsonProperty("start")]
        public long[] Start
        {
            get;
            set;
        }
        /// <summary>
        /// The number of characters in this post layout textbox substring. Characters that would be
        /// represented as a surrogate pair in UTF-16 have length 2.
        ///</summary>
        [JsonProperty("length")]
        public long[] Length
        {
            get;
            set;
        }
    }
}