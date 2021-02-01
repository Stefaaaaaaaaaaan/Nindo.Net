using System.Threading.Tasks;
using Nindo.Net.Interfaces;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;
using Refit;

namespace Nindo.Net.Clients
{
    public sealed class PostsClient
    {
        private readonly IPostsClient _service;

        public PostsClient()
        {
            _service = RestService.For<IPostsClient>("https://api.nindo.de/posts");
        }

        public async Task<PostBase[]> GetUserPostsAsync(PostsPlatform platform, string userId)
        {
            var result = await _service.GetUserPostsAsync(platform, userId);
            return result.Content;
        }
    }
}