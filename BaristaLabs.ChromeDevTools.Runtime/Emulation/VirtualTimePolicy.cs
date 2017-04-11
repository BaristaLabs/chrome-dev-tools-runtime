namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// advance: If the scheduler runs out of immediate work, the virtual time base may fast forward to allow the next delayed task (if any) to run; pause: The virtual time base may not advance; pauseIfNetworkFetchesPending: The virtual time base may not advance if there are any pending resource fetches.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class VirtualTimePolicy
    {
        private string m_value;
        
        public VirtualTimePolicy(string value)
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

    
        public static VirtualTimePolicy Advance = new VirtualTimePolicy("advance");
    
        public static VirtualTimePolicy Pause = new VirtualTimePolicy("pause");
    
        public static VirtualTimePolicy PauseIfNetworkFetchesPending = new VirtualTimePolicy("pauseIfNetworkFetchesPending");
    
    }
}