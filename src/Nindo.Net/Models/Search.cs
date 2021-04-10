using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class Search
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }
    }
}