using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class PostArtist : Artist
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
    }
}