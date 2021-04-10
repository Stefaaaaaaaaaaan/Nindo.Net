using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class PostAnalytics
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("age")]
        public ulong? Age { get; set; }

        [JsonPropertyName("value")]
        public ulong Value { get; set; }

        [JsonPropertyName("analyticsType")]
        public ulong AnalyticsType { get; set; }

        [JsonPropertyName("postID")]
        public string PostId { get; set; }

        [JsonPropertyName("channelID")]
        public string ChannelId { get; set; }
    }
}
