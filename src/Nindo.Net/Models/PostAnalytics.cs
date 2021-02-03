using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class PostAnalytics
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("age")]
        public ulong? Age { get; set; }

        [JsonProperty("value")]
        public ulong Value { get; set; }

        [JsonProperty("analyticsType")]
        public ulong AnalyticsType { get; set; }

        [JsonProperty("postID")]
        public string PostId { get; set; }

        [JsonProperty("channelID")]
        public string ChannelId { get; set; }
    }
}
