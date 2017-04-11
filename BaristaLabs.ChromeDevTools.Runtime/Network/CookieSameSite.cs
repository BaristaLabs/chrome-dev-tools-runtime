namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the cookie's 'SameSite' status: https://tools.ietf.org/html/draft-west-first-party-cookies
    /// </summary>
    [JsonConverter(typeof(StringClassConverter))]
    public sealed class CookieSameSite
    {
        private string m_value;
        
        public CookieSameSite(string value)
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

    
        public static CookieSameSite Strict = new CookieSameSite("Strict");
    
        public static CookieSameSite Lax = new CookieSameSite("Lax");
    
    }
}