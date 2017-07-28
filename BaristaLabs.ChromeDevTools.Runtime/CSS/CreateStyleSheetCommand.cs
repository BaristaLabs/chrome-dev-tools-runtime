namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Creates a new special &quot;via-inspector&quot; stylesheet in the frame with given &lt;code&gt;frameId&lt;/code&gt;.
    /// </summary>
    public sealed class CreateStyleSheetCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.createStyleSheet";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier of the frame where &quot;via-inspector&quot; stylesheet should be created.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    }

    public sealed class CreateStyleSheetCommandResponse : ICommandResponse<CreateStyleSheetCommand>
    {
        /// <summary>
        /// Identifier of the created &quot;via-inspector&quot; stylesheet.
        ///</summary>
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
    }
}