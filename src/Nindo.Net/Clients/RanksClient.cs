using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Nindo.Net.Interfaces;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;
using Refit;

namespace Nindo.Net.Clients
{
    public sealed class RanksClient
    {
        private readonly IRankClient _service;

        public RanksClient()
        {
            _service = RestService.For<IRankClient>("https://api.nindo.de/ranks"); 
        }


        public async Task<Rank[]> GetViewsScoreboardAsync(RankViewsPlatform platform, Size size)
        {
            var result = await _service.GetViewsScoreboardAsync(platform, size);
            return result.Content;
        }

        public async Task<Rank[]> GetViewersScoreboardAsync(RankViewerPlatform platform, Size size)
        {
            var result = await _service.GetViewersScoreboardAsync(platform, size);
            return result.Content;
        }

        public async Task<Rank[]> GetScoreboardAsync(RankAllPlatform platform, Size size)
        {
            var result = await _service.GetScoreboardAsync(platform, size);
            return result.Content;
        }

        public async Task<Rank[]> GetSubGainScoreboardAsync(RankAllPlatform platform, Size size)
        {
            var result = await _service.GetSubGainScoreboardAsync(platform, size);
            return result.Content;
        }

        public async Task<Rank[]> GetLikesScoreboardAsync(RankLikesPlatform platform, Size size)
        {
            var result = await _service.GetLikesScoreboardAsync(platform, size);
            return result.Content;
        }

        public async Task<Rank[]> GetPeakViewersScoreboardAsync(RankViewerPlatform platform, Size size)
        {
            var result = await _service.GetPeakViewersScoreboardAsync(platform, size);
            return result.Content;
        }

        public async Task<Rank[]> GetRetweetsScoreboardAsync(RankRetweetsPlatform platform, Size size)
        {
            var result = await _service.GetRetweetsScoreboardAsync(platform, size);
            return result.Content;
        }

        public async Task<Subscriber[]> GetSubscribersAsync(RankAllPlatform platform, Size size)
        {
            var result = await _service.GetSubscribersAsync(platform, size);
            return result.Content;
        }

        public async Task<Subscriber[]> GetMilestonesAsync()
        {
            var result = await _service.GetMilestonesAsync();
            return result.Content;
        }

        public async Task<Subscriber[]> GetPastMilestonesAsync()
        {
            var result = await _service.GetPastMilestonesAsync();
            return result.Content;
        }
    }
}