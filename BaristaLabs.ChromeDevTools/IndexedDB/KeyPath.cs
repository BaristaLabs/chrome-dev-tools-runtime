namespace BaristaLabs.ChromeDevTools.IndexedDB
{
    /// <summary>
    /// Key path.
    /// </summary>
    public sealed class KeyPath
    {
    
        /// <summary>
        /// Key path type.
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// String value.
        ///</summary>
        public string String
        {
            get;
            set;
        }
    
        /// <summary>
        /// Array value.
        ///</summary>
        public string[] Array
        {
            get;
            set;
        }
    
    }
}