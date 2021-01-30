using System.Threading.Tasks;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;
using Refit;

namespace Nindo.Net
{
    public interface IArtistClient
    {
        [Get("/{userId}")]
        Task<ApiResponse<Artist>> GetArtistInformationAsync(string userId);
    }
}