using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class PostArtistBase : ArtistBase
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }
    }
}