using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class CouponContent
    {
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        [JsonPropertyName("artistName")]
        public string ArtistName { get; set; }
    }
}