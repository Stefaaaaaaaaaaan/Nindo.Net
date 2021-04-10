using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class Subscriber : Rank
    {
        [JsonPropertyName("_artist")]
        public ArtistBase Artist { get; set; }

        [JsonPropertyName("diff")]
        public int? Diff { get; set; }
    }
}
