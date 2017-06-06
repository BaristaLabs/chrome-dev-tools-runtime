namespace BaristaLabs.ChromeDevTools.Runtime.Console
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when new console message is added.
    /// </summary>
    public sealed class MessageAddedEvent : IEvent
    {
    
        
        /// <summary>
        /// Console message that has been added.
        /// </summary>
        
        [JsonProperty("message")]
        public ConsoleMessage Message
        {
            get;
            set;
        }
    
    }
}