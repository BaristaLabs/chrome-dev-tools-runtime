namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// DragData
    /// </summary>
    public sealed class DragData
    {
        /// <summary>
        /// items
        ///</summary>
        [JsonProperty("items")]
        public DragDataItem[] Items
        {
            get;
            set;
        }
        /// <summary>
        /// List of filenames that should be included when dropping
        ///</summary>
        [JsonProperty("files", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Files
        {
            get;
            set;
        }
        /// <summary>
        /// Bit field representing allowed drag operations. Copy = 1, Link = 2, Move = 16
        ///</summary>
        [JsonProperty("dragOperationsMask")]
        public long DragOperationsMask
        {
            get;
            set;
        }
    }
}