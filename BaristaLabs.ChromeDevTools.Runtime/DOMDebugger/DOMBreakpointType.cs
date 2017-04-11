namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// DOM breakpoint type.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class DOMBreakpointType
    {
        private string m_value;
        
        public DOMBreakpointType(string value)
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

    
        public static DOMBreakpointType SubtreeModified = new DOMBreakpointType("subtree-modified");
    
        public static DOMBreakpointType AttributeModified = new DOMBreakpointType("attribute-modified");
    
        public static DOMBreakpointType NodeRemoved = new DOMBreakpointType("node-removed");
    
    }
}