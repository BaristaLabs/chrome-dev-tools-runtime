namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class ServiceWorkerVersionStatus
    {
        private string m_value;
        
        public ServiceWorkerVersionStatus(string value)
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

    
        public static ServiceWorkerVersionStatus New = new ServiceWorkerVersionStatus("new");
    
        public static ServiceWorkerVersionStatus Installing = new ServiceWorkerVersionStatus("installing");
    
        public static ServiceWorkerVersionStatus Installed = new ServiceWorkerVersionStatus("installed");
    
        public static ServiceWorkerVersionStatus Activating = new ServiceWorkerVersionStatus("activating");
    
        public static ServiceWorkerVersionStatus Activated = new ServiceWorkerVersionStatus("activated");
    
        public static ServiceWorkerVersionStatus Redundant = new ServiceWorkerVersionStatus("redundant");
    
    }
}