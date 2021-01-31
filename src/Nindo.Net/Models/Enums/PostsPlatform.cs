using System.Runtime.Serialization;

namespace Nindo.Net.Models.Enums
{
    public enum PostsPlatform
    {
        [EnumMember(Value = "instagram")]
        Instagram = 0,

        [EnumMember(Value = "tiktok")]
        TikTok = 1,

        [EnumMember(Value = "twitter")]
        Twitter = 2
    }
}
