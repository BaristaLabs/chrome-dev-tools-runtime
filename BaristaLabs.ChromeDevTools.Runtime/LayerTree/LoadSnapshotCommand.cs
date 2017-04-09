namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the snapshot identifier.
    /// </summary>
    public sealed class LoadSnapshotCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "LayerTree.loadSnapshot";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// An array of tiles composing the snapshot.
        /// </summary>
        
        [JsonProperty("tiles")]
        public PictureTile[] Tiles
        {
            get;
            set;
        }
    
    }

    public sealed class LoadSnapshotCommandResponse : ICommandResponse<LoadSnapshotCommand>
    {
    
        
        /// <summary>
        /// The id of the snapshot.
        ///</summary>
        
        [JsonProperty("snapshotId")]
        public string SnapshotId
        {
            get;
            set;
        }
    
    }
}