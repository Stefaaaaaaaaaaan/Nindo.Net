using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class CouponBase
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("content")]
        public CouponContent Content { get; set; }

        [JsonPropertyName("current")]
        public string Current { get; set; }
    }
}