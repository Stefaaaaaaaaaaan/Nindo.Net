using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class CouponContent
    {
        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("artistName")]
        public string ArtistName { get; set; }
    }
}