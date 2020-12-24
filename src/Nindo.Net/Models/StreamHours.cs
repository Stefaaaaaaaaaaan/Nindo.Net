using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class StreamHours
    {
        [JsonProperty("stop")] 
        public DateTime Stop { get; set; }

        [JsonProperty("start")]
        public DateTime Start { get; set; }
    }
}