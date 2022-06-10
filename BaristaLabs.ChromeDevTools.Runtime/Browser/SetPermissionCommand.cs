namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Set permission settings for given origin.
    /// </summary>
    public sealed class SetPermissionCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.setPermission";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Descriptor of permission to override.
        /// </summary>
        [JsonProperty("permission")]
        public PermissionDescriptor Permission
        {
            get;
            set;
        }
        /// <summary>
        /// Setting of the permission.
        /// </summary>
        [JsonProperty("setting")]
        public PermissionSetting Setting
        {
            get;
            set;
        }
        /// <summary>
        /// Origin the permission applies to, all origins if not specified.
        /// </summary>
        [JsonProperty("origin", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Origin
        {
            get;
            set;
        }
        /// <summary>
        /// Context to override. When omitted, default browser context is used.
        /// </summary>
        [JsonProperty("browserContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BrowserContextId
        {
            get;
            set;
        }
    }

    public sealed class SetPermissionCommandResponse : ICommandResponse<SetPermissionCommand>
    {
    }
}