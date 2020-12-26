using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class PostArtistBase : ArtistBase
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
    }
}