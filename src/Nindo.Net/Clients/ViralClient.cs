using System.Threading.Tasks;
using Nindo.Net.Interfaces;
using Nindo.Net.Models;
using Refit;

namespace Nindo.Net.Clients
{
    public sealed class ViralClient
    {
        private readonly IViralClient _service;

        public ViralClient()
        {
            _service = RestService.For<IViralClient>("https://api.nindo.de/viral");
        }

        public async Task<Viral[]> GetViralsAsync()
        {
            var result = await _service.GetViralsAsync();
            return result.Content;
        }
    }
}