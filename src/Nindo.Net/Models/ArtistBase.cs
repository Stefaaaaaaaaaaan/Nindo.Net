using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class ArtistBase
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}