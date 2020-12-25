using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    class PostAnalytics
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
        public string PostID { get; set; }

        [JsonProperty("channelID")]
        public string ChannelID { get; set; }
    }
}
