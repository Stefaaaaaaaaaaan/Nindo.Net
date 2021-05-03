using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class TwitchChannel : ChannelBase
    {
        [JsonPropertyName("live")]
        public bool Live { get; set; }

        [JsonPropertyName("sumViews30")]
        public ulong? SumViewsThirty { get; set; }

        [JsonPropertyName("peakViewer30")]
        public ulong? PeakViewerThirty { get; set; }

        [JsonPropertyName("sumDuration30")]
        public ulong? SumDurationThirty { get; set; }

        [JsonPropertyName("sumWatchTime30")]
        public ulong? SumWatchTimeThirty { get; set; }

        [JsonPropertyName("countStreams30")]
        public ulong? CountStreamsThirty { get; set; }

        [JsonPropertyName("avgViewer")]
        public ulong? AvgViewer { get; set; }

        [JsonPropertyName("avgDuration")]
        public ulong? AvgDuration { get; set; }

        [JsonPropertyName("rankViewer")]
        public ulong? RankViewer { get; set; }

        [JsonPropertyName("rankPeakViewer")]
        public ulong? RankPeakViewer { get; set; }

        [JsonPropertyName("rankWatchtime")]
        public ulong? RankWatchtime { get; set; }

        [JsonPropertyName("streamDays")] 
        public ulong[] StreamDays { get; set; }

        [JsonPropertyName("streamHours")] 
        public StreamHours[] StreamHours { get; set; }  


    }
}