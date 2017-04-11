namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class ServiceWorkerVersionRunningStatus
    {
        private string m_value;
        
        public ServiceWorkerVersionRunningStatus(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

        public override bool Equals(object obj)
        {
            return m_value.Equals(obj);
        }

        public override int GetHashCode()
        {
            return m_value.GetHashCode();
        }

    
        public static ServiceWorkerVersionRunningStatus Stopped = new ServiceWorkerVersionRunningStatus("stopped");
    
        public static ServiceWorkerVersionRunningStatus Starting = new ServiceWorkerVersionRunningStatus("starting");
    
        public static ServiceWorkerVersionRunningStatus Running = new ServiceWorkerVersionRunningStatus("running");
    
        public static ServiceWorkerVersionRunningStatus Stopping = new ServiceWorkerVersionRunningStatus("stopping");
    
    }
}