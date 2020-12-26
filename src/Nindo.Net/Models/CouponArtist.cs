using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class CouponArtist
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("brandID")]
        public string? BrandID { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("serachChannels")]
        public string[]? serachChannels { get; set; }

        [JsonProperty("channels")]
        public string[]? Channels { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }
    }
}
