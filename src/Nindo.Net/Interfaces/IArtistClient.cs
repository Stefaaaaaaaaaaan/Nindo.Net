using System.Threading.Tasks;
using Nindo.Net.Models;
using Refit;

namespace Nindo.Net.Interfaces
{
    public interface IArtistClient
    {
        [Get("/{userId}")]
        Task<ApiResponse<Artist>> GetArtistInformationAsync(string userId);
    }
}