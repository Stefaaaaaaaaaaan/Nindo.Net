using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class StreamHours
    {
        [JsonPropertyName("stop")] 
        public DateTime Stop { get; set; }

        [JsonPropertyName("start")]
        public DateTime Start { get; set; }
    }
}