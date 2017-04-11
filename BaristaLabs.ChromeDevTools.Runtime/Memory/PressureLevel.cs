namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Memory pressure level.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class PressureLevel
    {
        private string m_value;
        
        public PressureLevel(string value)
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

    
        public static PressureLevel Moderate = new PressureLevel("moderate");
    
        public static PressureLevel Critical = new PressureLevel("critical");
    
    }
}