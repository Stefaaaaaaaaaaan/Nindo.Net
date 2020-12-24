using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class TiktokChannel : ChannelBase
    {
        [JsonProperty("followings")] 
        public ulong Followings { get; set; }

        [JsonProperty("totalLikes")]
        public ulong TotalLikes { get; set; }

        [JsonProperty("likesGiven")]
        public ulong LikesGiven { get; set; }

        [JsonProperty("totalPosts")]
        public ulong TotalPosts { get; set; }

        [JsonProperty("avgLikes5")]
        public ulong AvgLikesFive { get; set; }

        [JsonProperty("avgComments5")]
        public ulong AvgCommentsFive { get; set; }

        [JsonProperty("avgShares5")]
        public ulong AvgSharesFive { get; set; }

        [JsonProperty("avgViews5")]
        public ulong AvgViewsFive { get; set; }

        [JsonProperty("avgEngagement5")]
        public double AvgEngagementFive { get; set; }

        [JsonProperty("rankLikes")]
        public ulong RankLikes { get; set; }

        [JsonProperty("rankComments")]
        public ulong RankComments { get; set; }

        [JsonProperty("rankShares")]
        public ulong RankShares { get; set; }

        [JsonProperty("rankViews")]
        public ulong RankViews { get; set; }
    }
}