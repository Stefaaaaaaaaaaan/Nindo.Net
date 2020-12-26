using System.Threading.Tasks;
using Nindo.Net.Helpers;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;

namespace Nindo.Net.Clients
{
    public class RanksClient
    {
        private readonly JsonHelper _jsonHelper;
        private readonly string _baseUrl = "https://api.nindo.de/ranks/";

        public RanksClient()
        {
            _jsonHelper = new JsonHelper();
        }


        public async Task<Rank[]> GetViewsScoreboardAsync(RankViewsPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}charts/{requestPlatform}/rankViews/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetViewersScoreboardAsync(RankViewerPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}charts/{requestPlatform}/rankViewer/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetScoreboardAsync(RankAllPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}charts/{requestPlatform}/rank/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetSubGainScoreboardAsync(RankAllPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}charts/{requestPlatform}/rankSubGain/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetLikesScoreboardAsync(RankLikesPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}charts/{requestPlatform}/rankLikes/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetPeakViewersScoreboardAsync(RankViewerPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}charts/{requestPlatform}/rankPeakViewer/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRetweetsScoreboardAsync(RankRetweets platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}charts/{requestPlatform}/rankRetweets/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Milestone[]> GetPastMilestonesAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}pastMilestones");
            var apiData = await _jsonHelper.Deserialise<Milestone[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Milestone[]> GetMilestonesAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}milestones");
            var apiData = await _jsonHelper.Deserialise<Milestone[]>(jsonAsStream);

            return apiData;
        }

    }
}