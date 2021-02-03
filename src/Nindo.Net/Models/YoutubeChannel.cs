using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class YoutubeChannel : ChannelBase
    {
        [JsonProperty("sumViews30")]
        public ulong SumViewsThirty { get; set; }

        [JsonProperty("avgViews5")]
        public ulong AvgViewsFive { get; set; }

        [JsonProperty("avgLikes5")]
        public ulong AvgLikesFive { get; set; }

        [JsonProperty("avgDislikes5")]
        public ulong AvgDislikesFive { get; set; }

        [JsonProperty("avgComments5")]
        public ulong AvgCommentsFive { get; set; }

        [JsonProperty("avgEngagement5")]
        public double AvgEngagementFive { get; set; }

        [JsonProperty("totalViews")]
        public ulong TotalViews { get; set; }

        [JsonProperty("totalVideos")]
        public ulong TotalVideos { get; set; }

        [JsonProperty("totalDeletedVideos")]
        public ulong TotalDeletedVideos { get; set; }

        [JsonProperty("videosPerMonth")]
        public ulong VideosPerMonth { get; set; }

        [JsonProperty("avgDuration")]
        public ulong AvgDuration { get; set; }

        [JsonProperty("totalDuration")]
        public ulong TotalDuration { get; set; }

        [JsonProperty("rankViews")]
        public ulong? RankViews { get; set; }

        [JsonProperty("rankComments")]
        public ulong? RankComments { get; set; }

        [JsonProperty("rankLikes")]
        public ulong? RankLikes { get; set; }

        [JsonProperty("rankDislikes")]
        public string RankDislikes { get; set; }

        [JsonProperty("calculatedDailyViews")]
        public string CalculatedDailyViews { get; set; }

        [JsonProperty("estimateSubs")]
        public string EstimateSubs { get; set; }
    }
}