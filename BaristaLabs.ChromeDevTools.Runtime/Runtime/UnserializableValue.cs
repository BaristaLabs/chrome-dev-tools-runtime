namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Primitive value which cannot be JSON-stringified.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class UnserializableValue
    {
        private string m_value;
        
        public UnserializableValue(string value)
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

    
        public static UnserializableValue Infinity = new UnserializableValue("Infinity");
    
        public static UnserializableValue NaN = new UnserializableValue("NaN");
    
        public static UnserializableValue NegativeInfinity = new UnserializableValue("-Infinity");
    
        public static UnserializableValue Negative0 = new UnserializableValue("-0");
    
    }
}