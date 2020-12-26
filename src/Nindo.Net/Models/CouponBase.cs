using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class CouponBase
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("content")]
        public CouponContent Content { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }
    }
}