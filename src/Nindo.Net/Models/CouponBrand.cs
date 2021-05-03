using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class CouponBrand
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }
    }
}
