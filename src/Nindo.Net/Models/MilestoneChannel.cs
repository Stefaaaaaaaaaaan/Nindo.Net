using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class MilestoneChannel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("milestone")]
        public bool Milestone { get; set; }

        [JsonProperty("artistID")]
        public string ArtistId { get; set; }

        [JsonProperty("_artist")]
        public Artist Artist { get; set; }
    }
}