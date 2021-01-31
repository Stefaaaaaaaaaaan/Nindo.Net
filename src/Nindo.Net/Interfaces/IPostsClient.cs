using System.Threading.Tasks;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;
using Refit;

namespace Nindo.Net.Interfaces
{
    public interface IPostsClient
    {
        [Get("/{platform}/{userId}")]
        Task<ApiResponse<PostBase[]>> GetUserPostsAsync(PostsPlatform platform, string userId);
    }
}