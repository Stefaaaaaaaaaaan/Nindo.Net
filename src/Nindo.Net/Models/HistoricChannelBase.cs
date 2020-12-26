using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class HistoricChannelBase
    {
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("followers")]
        public ulong Followers { get; set; }
    }
}
