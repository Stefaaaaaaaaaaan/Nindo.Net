using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class ArtistChannel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("channelID")]
        public string ChannelId { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isChartPlaced")]
        public bool IsChartPlaced { get; set; }

        [JsonProperty("isGerman")]
        public bool IsGerman { get; set; }

        [JsonProperty("ageInDB")]
        public ulong AgeInDB { get; set; }

        [JsonProperty("subscribers")]
        public ulong Subscribers { get; set; }

        [JsonProperty("rank")]
        public ulong? Rank { get; set; }
    }
}