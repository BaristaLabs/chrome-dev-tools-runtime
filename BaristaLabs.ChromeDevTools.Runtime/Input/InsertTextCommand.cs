namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// This method emulates inserting text that doesn't come from a key press,
    /// for example an emoji keyboard or an IME.
    /// </summary>
    public sealed class InsertTextCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Input.insertText";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The text to insert.
        /// </summary>
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
    }

    public sealed class InsertTextCommandResponse : ICommandResponse<InsertTextCommand>
    {
    }
}