using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class ArtistBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}