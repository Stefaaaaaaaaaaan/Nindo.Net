
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class Milestone
    {
        [JsonPropertyName("currentSubs")]
        public ulong CurrentSubs { get; set; }

        [JsonPropertyName("expectedTime")] 
        public string ExpectedTime { get; set; }

        [JsonPropertyName("_channel")] 
        public MilestoneChannel MilestoneChannel { get; set; }
    }
}