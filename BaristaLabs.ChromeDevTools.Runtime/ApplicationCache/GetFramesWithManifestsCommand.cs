namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns array of frame identifiers with manifest urls for each frame containing a document associated with some application cache.
    /// </summary>
    public sealed class GetFramesWithManifestsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "ApplicationCache.getFramesWithManifests";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetFramesWithManifestsCommandResponse : ICommandResponse<GetFramesWithManifestsCommand>
    {
    
        
        /// <summary>
        /// Array of frame identifiers with manifest urls for each frame containing a document associated with some application cache.
        ///</summary>
        
        [JsonProperty("frameIds")]
        public FrameWithManifest[] FrameIds
        {
            get;
            set;
        }
    
    }
}