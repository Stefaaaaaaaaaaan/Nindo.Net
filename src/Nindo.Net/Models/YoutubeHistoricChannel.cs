using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class YoutubeHistoricChannel : HistoricChannelBase
    {
        [JsonProperty("views")]
        public ulong? Views { get; set; }
    }
}
