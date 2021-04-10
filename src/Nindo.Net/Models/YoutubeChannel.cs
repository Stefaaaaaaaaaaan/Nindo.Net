using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class YoutubeChannel : ChannelBase
    {
        [JsonPropertyName("sumViews30")]
        public ulong SumViewsThirty { get; set; }

        [JsonPropertyName("avgViews5")]
        public ulong AvgViewsFive { get; set; }

        [JsonPropertyName("avgLikes5")]
        public ulong AvgLikesFive { get; set; }

        [JsonPropertyName("avgDislikes5")]
        public ulong AvgDislikesFive { get; set; }

        [JsonPropertyName("avgComments5")]
        public ulong AvgCommentsFive { get; set; }

        [JsonPropertyName("avgEngagement5")]
        public double AvgEngagementFive { get; set; }

        [JsonPropertyName("totalViews")]
        public ulong TotalViews { get; set; }

        [JsonPropertyName("totalVideos")]
        public ulong TotalVideos { get; set; }

        [JsonPropertyName("totalDeletedVideos")]
        public ulong TotalDeletedVideos { get; set; }

        [JsonPropertyName("videosPerMonth")]
        public ulong VideosPerMonth { get; set; }

        [JsonPropertyName("avgDuration")]
        public ulong AvgDuration { get; set; }

        [JsonPropertyName("totalDuration")]
        public ulong TotalDuration { get; set; }

        [JsonPropertyName("rankViews")]
        public ulong? RankViews { get; set; }

        [JsonPropertyName("rankComments")]
        public ulong? RankComments { get; set; }

        [JsonPropertyName("rankLikes")]
        public ulong? RankLikes { get; set; }

        [JsonPropertyName("rankDislikes")]
        public string RankDislikes { get; set; }

        [JsonPropertyName("calculatedDailyViews")]
        public string CalculatedDailyViews { get; set; }

        [JsonPropertyName("estimateSubs")]
        public string EstimateSubs { get; set; }
    }
}