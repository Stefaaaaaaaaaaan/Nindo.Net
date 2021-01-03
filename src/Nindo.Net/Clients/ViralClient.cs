using System.Threading.Tasks;
using Nindo.Net.Helpers;
using Nindo.Net.Models;

namespace Nindo.Net.Clients
{
    public class ViralClient
    {
        private readonly JsonHelper _jsonHelper;
        private readonly string _baseUrl = "https://api.nindo.de/viral";

        public ViralClient()
        {
            _jsonHelper = new JsonHelper();
        }

        public async Task<Viral[]> GetViralsAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}/");
            var apiData = await _jsonHelper.Deserialise<Viral[]>(jsonAsStream);

            return apiData;
        }
    }
}