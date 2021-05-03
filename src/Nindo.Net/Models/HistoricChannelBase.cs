using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class HistoricChannelBase
    {
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("followers")]
        public ulong? Followers { get; set; }
    }
}
