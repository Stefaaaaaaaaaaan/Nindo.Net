using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class YoutubeHistoricChannel : HistoricChannelBase
    {
        [JsonPropertyName("views")]
        public ulong? Views { get; set; }
    }
}
