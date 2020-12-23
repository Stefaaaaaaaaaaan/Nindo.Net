using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class Artist
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}