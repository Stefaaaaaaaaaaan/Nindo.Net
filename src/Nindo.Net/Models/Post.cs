using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class Post
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("contentChecked")]
        public bool ContentChecked { get; set; }

        [JsonPropertyName("FSK18")]
        public bool FskEigteen { get; set; }

        [JsonPropertyName("clickbait")]
        public string Clickbait { get; set; }

        [JsonPropertyName("shitstorm")]
        public string Shitstorm { get; set; }

        [JsonPropertyName("ad")]
        public string Ad { get; set; }

        [JsonPropertyName("potentialAd")]
        public string PotentialAd { get; set; }

        [JsonPropertyName("_channel")]
        public PostChannel Channel { get; set; }
    }
}