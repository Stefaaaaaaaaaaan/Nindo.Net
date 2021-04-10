using System;
using System.Text.Json.Serialization;

namespace Nindo.Net.Models
{
    public class Artist : ArtistBase
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("_genres")]
        public Genre[] Genre{ get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("avatarPlatform")]
        public string AvatarPlatform { get; set; }

        [JsonPropertyName("_channels")]
        public ArtistChannel[] Channels { get; set; }
    }
}