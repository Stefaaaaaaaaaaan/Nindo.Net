using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class Viral
    {
        [JsonProperty("postID")]
        public string PostId { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public ulong Value { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("_post")]
        public Post Post { get; set; }
    }
}