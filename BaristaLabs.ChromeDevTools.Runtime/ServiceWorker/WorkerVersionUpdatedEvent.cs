namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    /// <summary>
    /// 
    /// </summary>
    [Event("ServiceWorker.workerVersionUpdated")]
    public sealed class WorkerVersionUpdatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the versions
        /// </summary>
        
        public ServiceWorkerVersion[] Versions
        {
            get;
            set;
        }
    
    }
}