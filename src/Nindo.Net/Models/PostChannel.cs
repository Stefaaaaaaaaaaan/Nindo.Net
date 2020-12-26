using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class PostChannel
    {
        [JsonProperty("channelID")]
        public string ChannelId { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("cachedAvatar")]
        public bool CachedAvatar { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("lastPostID")]
        public string LastPostId { get; set; }

        [JsonProperty("_artist")]
        public PostArtistBase ArtistBase { get; set; }
    }
}