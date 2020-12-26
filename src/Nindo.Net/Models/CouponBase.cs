using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class CouponBase
    {
        [JsonProperty("coupons")]
        public CouponContent[] Coupons { get; set; }

        [JsonProperty("hasMore")]
        public string HasMore { get; set; }
    }
}
