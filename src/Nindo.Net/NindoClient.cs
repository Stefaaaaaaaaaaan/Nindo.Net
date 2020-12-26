using System;
using System.Collections.Generic;
using System.Net.Http;
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

        public async Task<Rank[]> GetRankByViewsAsync(RankViewsPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}ranks/charts/{requestPlatform}/rankViews/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankByViewersAsync(RankViewerPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}ranks/charts/{requestPlatform}/rankViewer/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankAsync(RankAllPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}ranks/charts/{requestPlatform}/rank/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankBySubGainAsync(RankAllPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}ranks/charts/{requestPlatform}/rankSubGain/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankByLikesAsync(RankLikesPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}ranks/charts/{requestPlatform}/rankLikes/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankByPeakViewersAsync(RankViewerPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}ranks/charts/{requestPlatform}/rankPeakViewer/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankByRetweetsAsync(RankRetweets platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}ranks/charts/{requestPlatform}/rankRetweets/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Milestone[]> GetPastMilestonesAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}ranks/pastMilestones");
            var apiData = await _jsonHelper.Deserialise<Milestone[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Milestone[]> GetMilestonesAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}ranks/milestones");
            var apiData = await _jsonHelper.Deserialise<Milestone[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Search[]> SearchAsync(string term)
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}search/smart/{term}");
            var apiData = await _jsonHelper.Deserialise<Search[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Viral[]> GetViralAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}viral");
            var apiData = await _jsonHelper.Deserialise<Viral[]>(jsonAsStream);

            return apiData;
        }

        public async Task<object> GetChannelInformationAsync(RankAllPlatform platform, string userId)
        {
            var requestPlatform = platform.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}channel/{requestPlatform}/{userId}");
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

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}channel/historic/{requestPlatform}/{userId}");
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
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}artist/{userId}");
            var apiData = await _jsonHelper.Deserialise<Artist>(jsonAsStream);

            return apiData;
        }

        public async Task<object> GetPostsAsync(PostsPlatform platform, string platformId)
        {
            var requestPlatform = platform.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}posts/{requestPlatform}/{platformId}");
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

        public async Task<Coupons> GetCouponsAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}coupons");
            var apiData = await _jsonHelper.Deserialise<Coupons>(jsonAsStream);

            return apiData;
        }

        public async Task<string[]> GetCouponBranchesAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}coupons/branches");
            var apiData = await _jsonHelper.Deserialise<string[]>(jsonAsStream);

            return apiData;
        }

        public async Task<CouponBrands[]> GetCouponsBrandsAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}coupons/brands");
            var apiData = await _jsonHelper.Deserialise<CouponBrands[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Coupons> GetCouponsBySortAsync(string category)
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}coupons/by/{category}");
            var apiData = await _jsonHelper.Deserialise<Coupons>(jsonAsStream);

            return apiData;
        }

        public async Task<Coupons> GetCouponsByBranchAsync(string id)
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}coupons/for/{id}");
            var apiData = await _jsonHelper.Deserialise<Coupons>(jsonAsStream);

            return apiData;
        }

        public async Task<HttpResponseMessage> SubmitCouponAsync(string brand, string artistName, string code, string discount)
        {
            var couponInformation =
                $"\"brand\":\"{brand}\",\"code\":\"{code}\",\"discount\":\"{discount}\",\"artistName\":\"{artistName}\"";
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("content", "{"+couponInformation+"}"),
                new KeyValuePair<string, string>("current", "0"),
                new KeyValuePair<string, string>("type", "newCoupon")

            }); var responseMessage = await ApiProcessor.PostAsync($"{_baseUrl}feedback", content);

            return responseMessage;
        }
    }
}