using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class Post
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("contentChecked")]
        public bool ContentChecked { get; set; }

        [JsonProperty("FSK18")]
        public bool FskEigteen { get; set; }

        [JsonProperty("clickbait")]
        public string Clickbait { get; set; }

        [JsonProperty("shitstorm")]
        public string Shitstorm { get; set; }

        [JsonProperty("ad")]
        public string Ad { get; set; }

        [JsonProperty("potentialAd")]
        public string PotentialAd { get; set; }

        [JsonProperty("_channel")]
        public PostChannel Channel { get; set; }
    }
}