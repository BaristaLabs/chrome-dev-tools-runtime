namespace BaristaLabs.ChromeDevTools.Runtime.DOMStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// DOM Storage identifier.
    /// </summary>
    public sealed class StorageId
    {
    
        /// <summary>
        /// Security origin for the storage.
        ///</summary>
        [JsonProperty("securityOrigin")]
        public string SecurityOrigin
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether the storage is local storage (not session storage).
        ///</summary>
        [JsonProperty("isLocalStorage")]
        public bool IsLocalStorage
        {
            get;
            set;
        }
    
    }
}