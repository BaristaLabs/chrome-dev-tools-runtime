namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class InspectMode
    {
        private string m_value;
        
        public InspectMode(string value)
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

    
        public static InspectMode SearchForNode = new InspectMode("searchForNode");
    
        public static InspectMode SearchForUAShadowDOM = new InspectMode("searchForUAShadowDOM");
    
        public static InspectMode None = new InspectMode("none");
    
    }
}