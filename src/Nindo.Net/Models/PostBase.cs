using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class PostBase
    {
        [JsonProperty("postID")]
        public string PostId { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("published")]
        public DateTime Published { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("analytics")]
        public PostAnalytics[] Analytics { get; set; }
    }
}
