using System.Threading.Tasks;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;
using Refit;

namespace Nindo.Net
{
    public interface IRankClient
    {
        [Get("/charts/{platform}/rankViews/{size}")]
        Task<ApiResponse<Rank[]>> GetViewsScoreboardAsync(RankViewsPlatform platform, Size size);

        [Get("/charts/{platform}/rankViewer/{size}")]
        Task<ApiResponse<Rank[]>> GetViewersScoreboardAsync(RankViewerPlatform platform, Size size);

        [Get("/charts/{platform}/rank/{size}")]
        Task<ApiResponse<Rank[]>> GetScoreboardAsync(RankAllPlatform platform, Size size);

        [Get("/charts/{platform}/rankSubGain/{size}")]
        Task<ApiResponse<Rank[]>> GetSubGainScoreboardAsync(RankAllPlatform platform, Size size);

        [Get("/charts/{platform}/rankLikes/{size}")]
        Task<ApiResponse<Rank[]>> GetLikesScoreboardAsync(RankLikesPlatform platform, Size size);

        [Get("/charts/{platform}/rankPeakViewer/{size}")]
        Task<ApiResponse<Rank[]>> GetPeakViewersScoreboardAsync(RankViewerPlatform platform, Size size);

        [Get("/charts/{platform}/rankRetweets/{size}")]
        Task<ApiResponse<Rank[]>> GetRetweetsScoreboardAsync(RankRetweetsPlatform platform, Size size);

        [Get("/charts/{platform}/subscribers/{size}")]
        Task<ApiResponse<Subscriber[]>> GetSubscribersAsync(RankAllPlatform platform, Size size);

        [Get("/milestones")]
        Task<ApiResponse<Subscriber[]>> GetMilestonesAsync();

        [Get("/pastMilestones")]
        Task<ApiResponse<Subscriber[]>> GetPastMilestonesAsync();
    }
}
