namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    /// <summary>
    /// 
    /// </summary>
    [Event("ServiceWorker.workerErrorReported")]
    public sealed class WorkerErrorReportedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the errorMessage
        /// </summary>
        
        public ServiceWorkerErrorMessage ErrorMessage
        {
            get;
            set;
        }
    
    }
}