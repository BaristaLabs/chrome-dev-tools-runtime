namespace BaristaLabs.ChromeDevTools.Runtime.Database
{
    using Newtonsoft.Json;

    /// <summary>
    /// AddDatabase
    /// </summary>
    public sealed class AddDatabaseEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the database
        /// </summary>
        [JsonProperty("database")]
        public Database Database
        {
            get;
            set;
        }
    }
}