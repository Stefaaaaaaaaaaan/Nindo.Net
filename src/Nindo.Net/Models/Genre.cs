using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class Genre
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}