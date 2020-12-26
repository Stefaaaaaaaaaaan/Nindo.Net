using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class Coupons
    {
        [JsonProperty("coupons")]
        public Coupon[] Coupon { get; set; }

        [JsonProperty("hasMore")]
        public string HasMore { get; set; }
    }
}
