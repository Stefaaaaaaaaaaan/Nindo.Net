using System;
using System.Threading.Tasks;
using Nindo.Net.Helpers;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;

namespace Nindo.Net.Clients
{
    public class ChannelClient
    {

        private readonly JsonHelper _jsonHelper;
        private readonly string _baseUrl = "https://api.nindo.de/channel";

        public ChannelClient()
        {
            _jsonHelper = new JsonHelper();
        }

        public async Task<object> GetChannelInformationAsync(RankAllPlatform platform, string userId)
        {
            var requestPlatform = platform.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}/{requestPlatform}/{userId}");
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

        public async Task<object> GetChannelHistoryAsync(RankAllPlatform platform, string userId)
        {
            var requestPlatform = platform.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}/historic/{requestPlatform}/{userId}");
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
    }
}