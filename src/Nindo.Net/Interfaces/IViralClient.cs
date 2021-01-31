using System.Threading.Tasks;
using Nindo.Net.Models;
using Refit;

namespace Nindo.Net.Interfaces
{
    public interface IViralClient
    {
        [Get("/")]
        Task<ApiResponse<Viral[]>> GetViralsAsync();
    }
}