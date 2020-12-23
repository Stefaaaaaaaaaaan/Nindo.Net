using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class Milestone
    {
        [JsonProperty("currentSubs")]
        public ulong CurrentSubs { get; set; }

        [JsonProperty("expectedTime")] 
        public string ExpectedTime { get; set; }

        [JsonProperty("_channel")] 
        public Channel Channel { get; set; }
    }
}