namespace BaristaLabs.ChromeDevTools.Runtime.DOMStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class DomStorageItemsClearedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the storageId
        /// </summary>
        
        [JsonProperty("storageId")]
        public StorageId StorageId
        {
            get;
            set;
        }
    
    }
}