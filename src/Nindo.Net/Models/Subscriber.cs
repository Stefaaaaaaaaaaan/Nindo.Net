using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class Subscriber : Rank
    {
        [JsonProperty("_artist")]
        public ArtistBase Artist { get; set; }

        [JsonProperty("diff")]
        public int? Diff { get; set; }
    }
}
