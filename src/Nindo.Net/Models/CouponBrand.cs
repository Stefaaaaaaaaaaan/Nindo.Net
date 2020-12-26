using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class CouponBrand
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("color")]
        public string? Color { get; set; }
    }
}
