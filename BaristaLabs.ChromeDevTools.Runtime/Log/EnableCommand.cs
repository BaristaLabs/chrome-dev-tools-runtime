namespace BaristaLabs.ChromeDevTools.Runtime.Log
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables log domain, sends the entries collected so far to the client by means of the &lt;code&gt;entryAdded&lt;/code&gt; notification.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Log.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}