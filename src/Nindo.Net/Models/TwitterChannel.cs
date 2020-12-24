using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class TwitterChannel : ChannelBase
    {
        [JsonProperty("avgLikes5")]
        public ulong AvgLikesFive { get; set; }

        [JsonProperty("avgReplies5")]
        public ulong AvgRepliesFive { get; set; }

        [JsonProperty("avgRetweets5")]
        public ulong AvgRetweetsFive { get; set; }

        [JsonProperty("avgEngagement5")]
        public double AvgEngagementFive { get; set; }

        [JsonProperty("countTweets")]
        public double CountTweets { get; set; }

        [JsonProperty("countRetweets")]
        public double CountRetweets { get; set; }

        [JsonProperty("countReplies")]
        public double CountReplies { get; set; }

        [JsonProperty("rankLikes")]
        public ulong RankLikes { get; set; }

        [JsonProperty("rankReplies")]
        public ulong RankReplies { get; set; }

        [JsonProperty("rankRetweets")]
        public ulong RrankRetweets { get; set; }
    }
}