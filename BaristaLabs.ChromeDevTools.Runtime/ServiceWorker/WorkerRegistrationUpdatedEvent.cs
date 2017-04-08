namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    /// <summary>
    /// 
    /// </summary>
    [Event("ServiceWorker.workerRegistrationUpdated")]
    public sealed class WorkerRegistrationUpdatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the registrations
        /// </summary>
        
        public ServiceWorkerRegistration[] Registrations
        {
            get;
            set;
        }
    
    }
}