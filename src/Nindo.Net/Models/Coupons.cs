using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class Coupons
    {
        [JsonPropertyName("coupons")]
        public Coupon[] Coupon { get; set; }

        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }
}
