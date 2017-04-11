namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Javascript dialog type.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class DialogType
    {
        private string m_value;
        
        public DialogType(string value)
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

    
        public static DialogType Alert = new DialogType("alert");
    
        public static DialogType Confirm = new DialogType("confirm");
    
        public static DialogType Prompt = new DialogType("prompt");
    
        public static DialogType Beforeunload = new DialogType("beforeunload");
    
    }
}