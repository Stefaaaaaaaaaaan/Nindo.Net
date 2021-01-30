using System;
using Nindo.Net.Models.Enums;

namespace Nindo.Net.Helpers
{
    internal static class PlatformExtensions
    {
        internal static string ToApiString(this RankViewsPlatform platform)
        {
            return platform switch
            {
                RankViewsPlatform.Youtube => "youtube",
                RankViewsPlatform.TikTok => "tiktok",
                _ => throw new NotSupportedException("Invalid platform type.")
            };
        }

        internal static string ToApiString(this RankViewerPlatform platform)
        {
            return platform switch
            {
                RankViewerPlatform.Twitch => "twitch",
                _ => throw new NotSupportedException("Invalid platform type.")
            };
        }

        internal static string ToApiString(this RankRetweetsPlatform platform)
        {
            return platform switch
            {
                RankRetweetsPlatform.Twitter => "twitter",
                _ => throw new NotSupportedException("Invalid platform type.")
            };
        }

        internal static string ToApiString(this PostsPlatform platform)
        {
            return platform switch
            {
                PostsPlatform.Instagram => "instagram",
                PostsPlatform.TikTok => "tiktok",
                PostsPlatform.Twitter => "twitter",
                _ => throw new NotSupportedException("Invalid platform type.")
            };
        }

        internal static string ToApiString(this RankLikesPlatform platform)
        {
            return platform switch
            {
                RankLikesPlatform.Youtube => "youtube",
                RankLikesPlatform.Instagram => "instagram",
                RankLikesPlatform.TikTok => "tiktok",
                RankLikesPlatform.Twitter => "twitter",
                _ => throw new NotSupportedException("Invalid platform type.")
            };
        }

        internal static string ToApiString(this RankAllPlatform platform)
        {
            return platform switch
            {
                RankAllPlatform.Youtube => "youtube",
                RankAllPlatform.Instagram => "instagram",
                RankAllPlatform.TikTok => "tiktok",
                RankAllPlatform.Twitch => "twitch",
                RankAllPlatform.Twitter => "twitter",
                _ => throw new NotSupportedException("Invalid platform type.")
            };
        }
    }
}