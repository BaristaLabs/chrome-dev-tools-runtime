namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Proceed: allow the navigation; Cancel: cancel the navigation; CancelAndIgnore: cancels the navigation and makes the requester of the navigation acts like the request was never made.
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class NavigationResponse
    {
        private string m_value;
        
        public NavigationResponse(string value)
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

    
        public static NavigationResponse Proceed = new NavigationResponse("Proceed");
    
        public static NavigationResponse Cancel = new NavigationResponse("Cancel");
    
        public static NavigationResponse CancelAndIgnore = new NavigationResponse("CancelAndIgnore");
    
    }
}