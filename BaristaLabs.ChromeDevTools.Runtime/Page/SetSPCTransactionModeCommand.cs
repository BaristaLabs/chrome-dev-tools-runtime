namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets the Secure Payment Confirmation transaction mode.
    /// https://w3c.github.io/secure-payment-confirmation/#sctn-automation-set-spc-transaction-mode
    /// </summary>
    public sealed class SetSPCTransactionModeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setSPCTransactionMode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the mode
        /// </summary>
        [JsonProperty("mode")]
        public string Mode
        {
            get;
            set;
        }
    }

    public sealed class SetSPCTransactionModeCommandResponse : ICommandResponse<SetSPCTransactionModeCommand>
    {
    }
}