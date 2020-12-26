using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class Genre
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}