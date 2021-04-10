using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class PostChannel
    {
        [JsonPropertyName("channelID")]
        public string ChannelId { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("cachedAvatar")]
        public bool CachedAvatar { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonPropertyName("lastPostID")]
        public string LastPostId { get; set; }

        [JsonPropertyName("_artist")]
        public PostArtistBase ArtistBase { get; set; }
    }
}