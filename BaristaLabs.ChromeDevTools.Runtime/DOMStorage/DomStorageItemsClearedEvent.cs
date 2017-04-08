namespace BaristaLabs.ChromeDevTools.Runtime.DOMStorage
{
    /// <summary>
    /// 
    /// </summary>
    [Event("DOMStorage.domStorageItemsCleared")]
    public sealed class DomStorageItemsClearedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the storageId
        /// </summary>
        
        public StorageId StorageId
        {
            get;
            set;
        }
    
    }
}