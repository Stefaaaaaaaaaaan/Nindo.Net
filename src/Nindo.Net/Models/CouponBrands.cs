using System;
using Newtonsoft.Json;


namespace Nindo.Net.Models
{
    public class CouponBrands
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
