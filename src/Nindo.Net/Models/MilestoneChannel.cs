using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class MilestoneChannel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        [JsonPropertyName("milestone")]
        public bool Milestone { get; set; }

        [JsonPropertyName("artistID")]
        public string ArtistId { get; set; }

        [JsonPropertyName("_artist")]
        public ArtistBase ArtistBase { get; set; }
    }
}