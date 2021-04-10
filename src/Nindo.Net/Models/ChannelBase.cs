using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class ChannelBase
    {
        [JsonPropertyName("id")] 
        public string Id { get; set; }

        [JsonPropertyName("name")] 
        public string Name { get; set; }

        [JsonPropertyName("channelID")]
        public string ChannelId { get; set; }

        [JsonPropertyName("userID")]
        public string UserId { get; set; }

        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("isChartPlaced")]
        public bool IsChartPlaced { get; set; }

        [JsonPropertyName("subscribers")]
        public ulong Subscribers { get; set; }

        [JsonPropertyName("subGain30")]
        public long? SubGainThirty { get; set; }

        [JsonPropertyName("rankSubGain")]
        public int? RankSubGain { get; set; }

        [JsonPropertyName("rank")]
        public int? Rank { get; set; }

        [JsonPropertyName("lastPost")]
        public string LastPost { get; set; }

        [JsonPropertyName("diff")]
        public string Diff { get; set; }
    }
}