using System.Threading.Tasks;
using Nindo.Net.Models;
using Refit;

namespace Nindo.Net.Interfaces
{
    public interface ISearchClient
    {
        [Get("/smart/{term}")]
        Task<ApiResponse<Search[]>> SearchUserAsync(string term);
    }
}