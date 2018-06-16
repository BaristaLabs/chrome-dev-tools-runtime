namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// RequestAppBanner
    /// </summary>
    public sealed class RequestAppBannerCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.requestAppBanner";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class RequestAppBannerCommandResponse : ICommandResponse<RequestAppBannerCommand>
    {
    }
}