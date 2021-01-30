using System.Threading.Tasks;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;
using Refit;

namespace Nindo.Net
{
    public interface ISearchClient
    {
        [Get("/smart/{term}")]
        Task<ApiResponse<Search[]>> SearchUserAsync(string term);
    }
}