using System.Threading.Tasks;
using Nindo.Net.Interfaces;
using Nindo.Net.Models;
using Refit;

namespace Nindo.Net.Clients
{
    public sealed class ArtistClient
    {
        private readonly IArtistClient _service;

        public ArtistClient()
        {
            _service = RestService.For<IArtistClient>("https://api.nindo.de/artist");
        }

        public async Task<Artist> GetArtistInformationAsync(string userId)
        {
            var result = await _service.GetArtistInformationAsync(userId);
            return result.Content;
        }
    }
}