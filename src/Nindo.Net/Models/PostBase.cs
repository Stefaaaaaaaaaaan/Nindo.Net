using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class PostBase
    {
        [JsonPropertyName("postID")]
        public string PostId { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("published")]
        public DateTime Published { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("analytics")]
        public PostAnalytics[] Analytics { get; set; }
    }
}
