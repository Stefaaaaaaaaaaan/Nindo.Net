using System;
using System.Threading.Tasks;
using Nindo.Net.Helpers;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;

namespace Nindo.Net
{
    public class NindoClient
    {
        private readonly JsonHelper _jsonHelper;
        private readonly string _baseUrl = "https://api.nindo.de/";

        public NindoClient()
        {
            _jsonHelper = new JsonHelper();
        }

        public async Task<Rank[]> GetRankViewsAsync(RankViewsPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}ranks/charts/{requestPlatform}/rankViews/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankViewerAsync(RankViewerPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}ranks/charts/{requestPlatform}/rankViewer/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankAsync(RankAllPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}ranks/charts/{requestPlatform}/rank/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankSubGainAsync(RankAllPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}ranks/charts/{requestPlatform}/rankSubGain/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankLikesAsync(RankLikesPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}ranks/charts/{requestPlatform}/rankLikes/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankPeakViewerAsync(RankViewerPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}ranks/charts/{requestPlatform}/rankPeakViewer/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankRetweetsAsync(RankRetweets platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}ranks/charts/{requestPlatform}/rankRetweets/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Milestone[]> GetPastMilestonesAsync()
        {
            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}ranks/pastMilestones");
            var apiData = await _jsonHelper.Deserialise<Milestone[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Milestone[]> GetMilestonesAsync()
        {
            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}ranks/milestones");
            var apiData = await _jsonHelper.Deserialise<Milestone[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Search[]> GetSearchAsync(string term)
        {
            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}search/smart/{term}");
            var apiData = await _jsonHelper.Deserialise<Search[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Viral[]> GetViralAsync()
        {
            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}viral");
            var apiData = await _jsonHelper.Deserialise<Viral[]>(jsonAsStream);

            return apiData;
        }

        public async Task<object> GetChannelInformationAsync(RankAllPlatform platform, string userId)
        {
            var requestPlatform = platform.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}channel/{requestPlatform}/{userId}");
            object apiData;
            switch (platform)
            {
                case RankAllPlatform.Youtube:
                    apiData = await _jsonHelper.Deserialise<YoutubeChannel>(jsonAsStream);
                    break;
                case RankAllPlatform.Instagram:
                    apiData = await _jsonHelper.Deserialise<InstagramChannel>(jsonAsStream);
                    break;
                case RankAllPlatform.TikTok:
                    apiData = await _jsonHelper.Deserialise<TiktokChannel>(jsonAsStream);
                    break;
                case RankAllPlatform.Twitch:
                    apiData = await _jsonHelper.Deserialise<TwitchChannel>(jsonAsStream);
                    break;
                case RankAllPlatform.Twitter:
                    apiData = await _jsonHelper.Deserialise<TwitterChannel>(jsonAsStream);
                    break;
                default:
                    throw new NotSupportedException("Invalid platform type.");
            }
            return apiData;
        }

        public async Task<object> GetHistoricChannelAsync(RankAllPlatform platform, string userId)
        {
            var requestPlatform = platform.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}channel/historic/{requestPlatform}/{userId}");
            object apiData;
            switch (platform)
            {
                case RankAllPlatform.Youtube:
                    apiData = await _jsonHelper.Deserialise<YoutubeHistoricChannel[]>(jsonAsStream);
                    break;
                case RankAllPlatform.Instagram:
                    apiData = await _jsonHelper.Deserialise<HistoricChannelBase[]>(jsonAsStream);
                    break;
                case RankAllPlatform.TikTok:
                    apiData = await _jsonHelper.Deserialise<HistoricChannelBase[]>(jsonAsStream);
                    break;
                case RankAllPlatform.Twitch:
                    apiData = await _jsonHelper.Deserialise<HistoricChannelBase[]>(jsonAsStream);
                    break;
                case RankAllPlatform.Twitter:
                    apiData = await _jsonHelper.Deserialise<HistoricChannelBase[]>(jsonAsStream);
                    break;
                default:
                    throw new NotSupportedException("Invalid platform type.");
            }
            return apiData;
        }

        public async Task<Artist> GetArtistAsync(string userId)
        {
            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}artist/{userId}");
            var apiData = await _jsonHelper.Deserialise<Artist>(jsonAsStream);

            return apiData;
        }

        public async Task<object> GetPostsAsync(PostsPlatform platform, string PlatformID)
        {
            var requestPlatform = platform.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}posts/{requestPlatform}/{PlatformID}");
            object apiData;
            switch (platform)
            {
                case PostsPlatform.Instagram:
                    apiData = await _jsonHelper.Deserialise<PostBase[]>(jsonAsStream);
                    break;
                case PostsPlatform.TikTok:
                    apiData = await _jsonHelper.Deserialise<PostBase[]>(jsonAsStream);
                    break;
                case PostsPlatform.Twitter:
                    apiData = await _jsonHelper.Deserialise<PostBase[]>(jsonAsStream);
                    break;
                default:
                    throw new NotSupportedException("Invalid platform type.");
            }
            return apiData;
        }

        public async Task<CouponBase> GetCouponsAsync()
        {
            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}coupons");
            var apiData = await _jsonHelper.Deserialise<CouponBase>(jsonAsStream);

            return apiData;
        }

        public async Task<string[]> GetCouponBranchesAsync()
        {
            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}coupons/branches");
            var apiData = await _jsonHelper.Deserialise<string[]>(jsonAsStream);

            return apiData;
        }

        public async Task<CouponBrands[]> GetCouponsBrandsAsync()
        {
            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}coupons/brands");
            var apiData = await _jsonHelper.Deserialise<CouponBrands[]>(jsonAsStream);

            return apiData;
        }

        public async Task<CouponBase> GetCouponsBySortAsync(String categorie)
        {
            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}coupons/by/{categorie}");
            var apiData = await _jsonHelper.Deserialise<CouponBase>(jsonAsStream);

            return apiData;
        }

        public async Task<CouponBase> GetCouponsForBranchAsync(String id)
        {
            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}coupons/for/{id}");
            var apiData = await _jsonHelper.Deserialise<CouponBase>(jsonAsStream);

            return apiData;
        }
    }
}