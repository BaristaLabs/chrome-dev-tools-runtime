namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Intercept file chooser requests and transfer control to protocol clients.
    /// When file chooser interception is enabled, native file chooser dialog is not shown.
    /// Instead, a protocol event `Page.fileChooserOpened` is emitted.
    /// </summary>
    public sealed class SetInterceptFileChooserDialogCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setInterceptFileChooserDialog";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetInterceptFileChooserDialogCommandResponse : ICommandResponse<SetInterceptFileChooserDialogCommand>
    {
    }
}