using System;
using System.Threading.Tasks;
using Nindo.Net.Helpers;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;

namespace Nindo.Net.Clients
{
    public class PostsClient
    {
        private readonly JsonHelper _jsonHelper;
        private readonly string _baseUrl = "https://api.nindo.de/posts/";

        public PostsClient()
        {
            _jsonHelper = new JsonHelper();
        }

        public async Task<object> GetUserPostsAsync(PostsPlatform platform, string platformId)
        {
            var requestPlatform = platform.ToApiString();

            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}{requestPlatform}/{platformId}");
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
    }
}