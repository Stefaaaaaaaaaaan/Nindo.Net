using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class Artist : ArtistBase
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("_genres")]
        public Genre[] Genre{ get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("avatarPlatform")]
        public string AvatarPlatform { get; set; }

        [JsonProperty("_channels")]
        public ArtistChannel[] Channels { get; set; }
    }
}