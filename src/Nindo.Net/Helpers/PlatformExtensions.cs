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

        internal static string ToApiString(this RankViewerPlatform platform)
        {
            switch (platform)
            {
                case RankViewerPlatform.Twitch:
                    return "twitch";
                default:
                    throw new NotSupportedException("Invalid platform type.");
            }
        }

        internal static string ToApiString(this RankRetweets platform)
        {
            switch (platform)
            {
                case RankRetweets.Twitter:
                    return "twitter";
                default:
                    throw new NotSupportedException("Invalid platform type.");
            }
        }

        internal static string ToApiString(this RankLikesPlatform platform)
        {
            switch (platform)
            {
                case RankLikesPlatform.Youtube:
                    return "youtube";
                case RankLikesPlatform.Instagram:
                    return "instagram";
                case RankLikesPlatform.TikTok:
                    return "tiktok";
                case RankLikesPlatform.Twitter:
                    return "twitter";
                default:
                    throw new NotSupportedException("Invalid platform type.");
            }
        }

        internal static string ToApiString(this RankAllPlatform platform)
        {
            switch (platform)
            {
                case RankAllPlatform.Youtube:
                    return "youtube";
                case RankAllPlatform.Instagram:
                    return "instagram";
                case RankAllPlatform.TikTok:
                    return "tiktok";
                case RankAllPlatform.Twitch:
                    return "twitch";
                case RankAllPlatform.Twitter:
                    return "twitter";
                default:
                    throw new NotSupportedException("Invalid platform type.");
            }
        }
    }
}