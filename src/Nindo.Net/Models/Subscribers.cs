using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class Subscribers
    {
        [JsonProperty("rankBase")]
        public Rank RankBase { get; set; }

        [JsonProperty("artistBase")]
        public ArtistBase ArtistBase { get; set; }

        [JsonProperty("diff")]
        public int? Diff { get; set; }
    }
}
