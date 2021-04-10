using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class TwitterChannel : ChannelBase
    {
        [JsonPropertyName("avgLikes5")]
        public ulong AvgLikesFive { get; set; }

        [JsonPropertyName("avgReplies5")]
        public ulong AvgRepliesFive { get; set; }

        [JsonPropertyName("avgRetweets5")]
        public ulong AvgRetweetsFive { get; set; }

        [JsonPropertyName("avgEngagement5")]
        public double AvgEngagementFive { get; set; }

        [JsonPropertyName("countTweets")]
        public double CountTweets { get; set; }

        [JsonPropertyName("countRetweets")]
        public double CountRetweets { get; set; }

        [JsonPropertyName("countReplies")]
        public double CountReplies { get; set; }

        [JsonPropertyName("rankLikes")]
        public ulong RankLikes { get; set; }

        [JsonPropertyName("rankReplies")]
        public ulong RankReplies { get; set; }

        [JsonPropertyName("rankRetweets")]
        public ulong RrankRetweets { get; set; }
    }
}