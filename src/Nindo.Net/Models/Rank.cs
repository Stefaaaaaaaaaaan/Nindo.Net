using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class Rank
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("rank")]
        public int RankNumber { get; set; }

        [JsonPropertyName("userID")]
        public string UserId { get; set; }

        [JsonPropertyName("value")]
        public long? Value { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("artistName")]
        public string ArtistName { get; set; }

        [JsonPropertyName("artistID")]
        public string ArtistId { get; set; }

        [JsonPropertyName("showChannelName")]
        public bool ShowChannelName { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

    }
}