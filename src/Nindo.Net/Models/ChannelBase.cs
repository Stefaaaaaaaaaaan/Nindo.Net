using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class ChannelBase
    {
        [JsonProperty("id")] 
        public string Id { get; set; }

        [JsonProperty("name")] 
        public string Name { get; set; }

        [JsonProperty("channelID")]
        public string ChannelId { get; set; }

        [JsonProperty("userID")]
        public string UserId { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isChartPlaced")]
        public bool IsChartPlaced { get; set; }

        [JsonProperty("subscribers")]
        public ulong Subscribers { get; set; }

        [JsonProperty("subGain30")]
        public long SubGainThirty { get; set; }

        [JsonProperty("rankSubGain")]
        public string RankSubGain { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("lastPost")]
        public string LastPost { get; set; }

        [JsonProperty("diff")]
        public string Diff { get; set; }
    }
}