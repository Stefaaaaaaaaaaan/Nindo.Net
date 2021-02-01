using System.Threading.Tasks;
using Nindo.Net.Interfaces;
using Nindo.Net.Models;
using Refit;

namespace Nindo.Net.Clients
{
    public sealed class ChannelClient 
    {
        private readonly IChannelClient _service;

        public ChannelClient()
        {
            _service = RestService.For<IChannelClient>("https://api.nindo.de/channel");

        }

        public async Task<YoutubeChannel> GetYouTubeChannelInformationAsync(string userId)
        {
            var result = await _service.GetYouTubeChannelInformationAsync(userId);
            return result.Content;
        }

        public async Task<InstagramChannel> GetInstagramChannelInformationAsync(string userId)
        {
            var result = await _service.GetInstagramChannelInformationAsync(userId);
            return result.Content;
        }

        public async Task<TiktokChannel> GetTikTokChannelInformationAsync(string userId)
        {
            var result = await _service.GetTikTokChannelInformationAsync(userId);
            return result.Content;
        }

        public async Task<TwitchChannel> GetTwitchChannelInformationAsync(string userId)
        {
            var result = await _service.GetTwitchChannelInformationAsync(userId);
            return result.Content;
        }

        public async Task<TwitterChannel> GetTwitterChannelInformationAsync(string userId)
        {
            var result = await _service.GetTwitterChannelInformationAsync(userId);
            return result.Content;
        }

        public async Task<YoutubeChannel> GetYouTubeChannelHistoryAsync(string userId)
        {
            var result = await _service.GetYouTubeChannelHistoryAsync(userId);
            return result.Content;
        }

        public async Task<InstagramChannel> GetInstagramChannelHistoryAsync(string userId)
        {
            var result = await _service.GetInstagramChannelHistoryAsync(userId);
            return result.Content;
        }

        public async Task<TiktokChannel> GetTikTokChannelHistoryAsync(string userId)
        {
            var result = await _service.GetTikTokChannelHistoryAsync(userId);
            return result.Content;
        }

        public async Task<TwitchChannel> GetTwitchChannelHistoryAsync(string userId)
        {
            var result = await _service.GetTwitchChannelHistoryAsync(userId);
            return result.Content;
        }

        public async Task<TwitterChannel> GetTwitterChannelHistoryAsync(string userId)
        {
            var result = await _service.GetTwitterChannelHistoryAsync(userId);
            return result.Content;
        }
    }
}