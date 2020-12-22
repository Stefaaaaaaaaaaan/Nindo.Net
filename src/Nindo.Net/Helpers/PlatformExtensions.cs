using System;
using Nindo.Net.Models.Enums;

namespace Nindo.Net.Helpers
{
    internal static class PlatformExtensions
    {
        internal static string ToApiString(this RankViewsPlatform platform)
        {
            switch (platform)
            {
                case RankViewsPlatform.Youtube:
                    return "youtube";
                case RankViewsPlatform.TikTok:
                    return "tiktok";
                default:
                    throw new NotSupportedException("Invalid platform type.");
            }
        }
    }
}