using System.Threading.Tasks;
using Nindo.Net.Helpers;
using Nindo.Net.Models;

namespace Nindo.Net.Clients
{
    public class ArtistClient
    {
        private readonly JsonHelper _jsonHelper;
        private readonly string _baseUrl = "https://api.nindo.de/artist";

        public ArtistClient()
        {
            _jsonHelper = new JsonHelper();
        }

        public async Task<Artist> GetArtistInformationAsync(string userId)
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}/{userId}");
            var apiData = await _jsonHelper.Deserialise<Artist>(jsonAsStream);

            return apiData;
        }
    }
}