namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// WebSocket frame data.
    /// </summary>
    public sealed class WebSocketFrame
    {
        /// <summary>
        /// WebSocket frame opcode.
        ///</summary>
        [JsonProperty("opcode")]
        public double Opcode
        {
            get;
            set;
        }
        /// <summary>
        /// WebSocke frame mask.
        ///</summary>
        [JsonProperty("mask")]
        public bool Mask
        {
            get;
            set;
        }
        /// <summary>
        /// WebSocke frame payload data.
        ///</summary>
        [JsonProperty("payloadData")]
        public string PayloadData
        {
            get;
            set;
        }
    }
}