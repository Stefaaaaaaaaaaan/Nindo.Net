using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class InstagramChannel : ChannelBase
    {
        [JsonProperty("totalPosts")]
        public ulong TotalPosts { get; set; }

        [JsonProperty("totalIGTV")]
        public ulong TotalIgtv { get; set; }

        [JsonProperty("avgLikes5")]
        public ulong AvgLikesFive { get; set; }

        [JsonProperty("avgComments5")]
        public ulong AvgCommentsFive { get; set; }

        [JsonProperty("avgEngagement5")]
        public double AvgEngagementFive { get; set; }

        [JsonProperty("sumPosts30")]
        public ulong SumPostsThirty { get; set; }

        [JsonProperty("rankLikes")]
        public ulong RankLikes { get; set; }

        [JsonProperty("rankComments")]
        public ulong RankComments { get; set; }
    }
}