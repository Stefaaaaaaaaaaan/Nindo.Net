using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class TiktokChannel : ChannelBase
    {
        [JsonPropertyName("followings")] 
        public string Followings { get; set; }

        [JsonPropertyName("totalLikes")]
        public string TotalLikes { get; set; }

        [JsonPropertyName("likesGiven")]
        public string LikesGiven { get; set; }

        [JsonPropertyName("totalPosts")]
        public string TotalPosts { get; set; }

        [JsonPropertyName("avgLikes5")]
        public ulong AvgLikesFive { get; set; }

        [JsonPropertyName("avgComments5")]
        public ulong AvgCommentsFive { get; set; }

        [JsonPropertyName("avgShares5")]
        public ulong AvgSharesFive { get; set; }

        [JsonPropertyName("avgViews5")]
        public ulong AvgViewsFive { get; set; }

        [JsonPropertyName("avgEngagement5")]
        public double AvgEngagementFive { get; set; }

        [JsonPropertyName("rankLikes")]
        public ulong? RankLikes { get; set; }

        [JsonPropertyName("rankComments")]
        public string RankComments { get; set; }

        [JsonPropertyName("rankShares")]
        public string RankShares { get; set; }

        [JsonPropertyName("rankViews")]
        public ulong? RankViews { get; set; }
    }
}