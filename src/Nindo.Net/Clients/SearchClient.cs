using System.Threading.Tasks;
using Nindo.Net.Helpers;
using Nindo.Net.Models;

namespace Nindo.Net.Clients
{
    public class SearchClient
    {
        private readonly JsonHelper _jsonHelper;
        private readonly string _baseUrl = "https://api.nindo.de/search/";

        public SearchClient()
        {
            _jsonHelper = new JsonHelper();
        }

        public async Task<Search[]> SearchUserAsync(string term)
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}smart/{term}");
            var apiData = await _jsonHelper.Deserialise<Search[]>(jsonAsStream);

            return apiData;
        }
    }
}