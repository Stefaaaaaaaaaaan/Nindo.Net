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
    }
}