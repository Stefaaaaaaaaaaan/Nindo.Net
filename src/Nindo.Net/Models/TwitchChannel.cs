using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class TwitchChannel : ChannelBase
    {
        [JsonProperty("live")]
        public bool Live { get; set; }

        [JsonProperty("sumViews30")]
        public ulong SumViewsThirty { get; set; }

        [JsonProperty("peakViewer30")]
        public ulong PeakViewerThirty { get; set; }

        [JsonProperty("sumDuration30")]
        public ulong SumDurationThirty { get; set; }

        [JsonProperty("sumWatchTime30")]
        public ulong SumWatchTimeThirty { get; set; }

        [JsonProperty("countStreams30")]
        public ulong CountStreamsThirty { get; set; }

        [JsonProperty("avgViewer")]
        public ulong AvgViewer { get; set; }

        [JsonProperty("avgDuration")]
        public ulong AvgDuration { get; set; }

        [JsonProperty("rankViewer")]
        public ulong RankViewer { get; set; }

        [JsonProperty("rankPeakViewer")]
        public ulong RankPeakViewer { get; set; }

        [JsonProperty("rankWatchtime")]
        public ulong RankWatchtime { get; set; }

        [JsonProperty("streamDays")] 
        public ulong[] StreamDays { get; set; }

        [JsonProperty("streamHours")] 
        public StreamHours[] StreamHours { get; set; }  


    }
}