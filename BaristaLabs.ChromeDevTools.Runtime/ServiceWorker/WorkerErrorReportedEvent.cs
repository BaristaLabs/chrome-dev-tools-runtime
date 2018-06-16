namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// WorkerErrorReported
    /// </summary>
    public sealed class WorkerErrorReportedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the errorMessage
        /// </summary>
        [JsonProperty("errorMessage")]
        public ServiceWorkerErrorMessage ErrorMessage
        {
            get;
            set;
        }
    }
}