namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// Relationships between elements other than parent/child/sibling.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class AXRelationshipAttributes
    {
        private string m_value;
        
        public AXRelationshipAttributes(string value)
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

    
        public static AXRelationshipAttributes Activedescendant = new AXRelationshipAttributes("activedescendant");
    
        public static AXRelationshipAttributes Flowto = new AXRelationshipAttributes("flowto");
    
        public static AXRelationshipAttributes Controls = new AXRelationshipAttributes("controls");
    
        public static AXRelationshipAttributes Describedby = new AXRelationshipAttributes("describedby");
    
        public static AXRelationshipAttributes Labelledby = new AXRelationshipAttributes("labelledby");
    
        public static AXRelationshipAttributes Owns = new AXRelationshipAttributes("owns");
    
    }
}