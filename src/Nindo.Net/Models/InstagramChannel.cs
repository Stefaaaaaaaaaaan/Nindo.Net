using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class InstagramChannel : ChannelBase
    {
        [JsonPropertyName("totalPosts")]
        public ulong? TotalPosts { get; set; }

        [JsonPropertyName("totalIGTV")]
        public ulong? TotalIgtv { get; set; }

        [JsonPropertyName("avgLikes5")]
        public ulong? AvgLikesFive { get; set; }

        [JsonPropertyName("avgComments5")]
        public ulong? AvgCommentsFive { get; set; }

        [JsonPropertyName("avgEngagement5")]
        public double? AvgEngagementFive { get; set; }

        [JsonPropertyName("sumPosts30")]
        public ulong? SumPostsThirty { get; set; }

        [JsonPropertyName("rankLikes")]
        public ulong? RankLikes { get; set; }

        [JsonPropertyName("rankComments")]
        public ulong? RankComments { get; set; }
    }
}