namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Print page as pdf.
    /// </summary>
    public sealed class PrintToPDFCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.printToPDF";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class PrintToPDFCommandResponse : ICommandResponse<PrintToPDFCommand>
    {
    
        
        /// <summary>
        /// Base64-encoded pdf data.
        ///</summary>
        
        [JsonProperty("data")]
        public string Data
        {
            get;
            set;
        }
    
    }
}