using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class ArtistChannel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("channelID")]
        public string ChannelId { get; set; }

        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("isChartPlaced")]
        public bool IsChartPlaced { get; set; }

        [JsonPropertyName("isGerman")]
        public bool IsGerman { get; set; }

        [JsonPropertyName("ageInDB")]
        public ulong AgeInDb { get; set; }

        [JsonPropertyName("subscribers")]
        public ulong Subscribers { get; set; }

        [JsonPropertyName("rank")]
        public ulong? Rank { get; set; }
    }
}