using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class Rank
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rank")]
        public int RankNumber { get; set; }

        [JsonProperty("userID")]
        public string UserId { get; set; }

        [JsonProperty("value")]
        public ulong Value { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("artistName")]
        public string ArtistName { get; set; }

        [JsonProperty("artistID")]
        public string ArtistId { get; set; }

        [JsonProperty("showChannelName")]
        public bool ShowChannelName { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

    }
}