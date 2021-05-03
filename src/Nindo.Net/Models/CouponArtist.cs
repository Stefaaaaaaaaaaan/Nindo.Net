using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class CouponArtist
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("brandID")]
        public ulong? BrandId { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("serachChannels")]
        public string[] SerachChannels { get; set; }

        [JsonPropertyName("channels")]
        public string[] Channels { get; set; }

        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }
    }
}
