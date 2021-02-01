using System.Threading.Tasks;
using Nindo.Net.Interfaces;
using Nindo.Net.Models;
using Refit;

namespace Nindo.Net.Clients
{
    public sealed class SearchClient 
    {
        private readonly ISearchClient _service;

        public SearchClient()
        {
            _service = RestService.For<ISearchClient>("https://api.nindo.de/search");
        }
        public async Task<Search[]> SearchUserAsync(string term)
        {
            var result = await _service.SearchUserAsync(term);
            return result.Content;
        }
    }
}