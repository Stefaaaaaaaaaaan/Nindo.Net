using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class Coupon
    {
        [JsonPropertyName("timestamp")]
        public string Views { get; set; }

        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("terms")]
        public string? Terms { get; set; }

        [JsonPropertyName("valid")]
        public bool Valid { get; set; }

        [JsonPropertyName("validUntil")]
        public string ValidUntil { get; set; }

        [JsonPropertyName("artistID")]
        public string ArtistId { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("_artist")]
        public CouponArtist Artist { get; set; }

        [JsonPropertyName("_brand")]
        public CouponBrand Brand { get; set; }
    }
}