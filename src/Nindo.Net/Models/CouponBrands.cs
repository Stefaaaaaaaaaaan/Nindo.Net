using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class CouponBrands
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
