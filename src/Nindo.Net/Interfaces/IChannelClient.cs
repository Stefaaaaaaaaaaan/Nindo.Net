using System.Threading.Tasks;
using Nindo.Net.Models;
using Refit;

namespace Nindo.Net.Interfaces
{
    public interface IChannelClient
    {
        [Get("/youtube/{userId}")]
        Task<ApiResponse<YoutubeChannel>> GetYouTubeChannelInformationAsync(string userId);

        [Get("/instagram/{userId}")]
        Task<ApiResponse<InstagramChannel>> GetInstagramChannelInformationAsync(string userId);

        [Get("/tiktok/{userId}")]
        Task<ApiResponse<TiktokChannel>> GetTikTokChannelInformationAsync(string userId);

        [Get("/twitch/{userId}")]
        Task<ApiResponse<TwitchChannel>> GetTwitchChannelInformationAsync(string userId);

        [Get("/twitter/{userId}")]
        Task<ApiResponse<TwitterChannel>> GetTwitterChannelInformationAsync(string userId);


        [Get("/historic/youtube/{userId}")]
        Task<ApiResponse<YoutubeChannel>> GetYouTubeChannelHistoryAsync(string userId);

        [Get("/historic/instagram/{userId}")]
        Task<ApiResponse<InstagramChannel>> GetInstagramChannelHistoryAsync(string userId);

        [Get("/historic/tiktok/{userId}")]
        Task<ApiResponse<TiktokChannel>> GetTikTokChannelHistoryAsync(string userId);

        [Get("/historic/twitch/{userId}")]
        Task<ApiResponse<TwitchChannel>> GetTwitchChannelHistoryAsync(string userId);

        [Get("/historic/twitter/{userId}")]
        Task<ApiResponse<TwitterChannel>> GetTwitterChannelHistoryAsync(string userId);
    }
}