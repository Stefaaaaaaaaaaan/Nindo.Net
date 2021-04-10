using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class Viral
    {
        [JsonPropertyName("postID")]
        public string PostId { get; set; }

        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public ulong Value { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("_post")]
        public Post Post { get; set; }
    }
}