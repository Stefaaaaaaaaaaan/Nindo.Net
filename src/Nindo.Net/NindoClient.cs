using System.Threading.Tasks;
using Nindo.Net.Helpers;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;

namespace Nindo.Net
{
    public class NindoClient
    {
        private readonly JsonHelper _jsonHelper;
        private readonly string _baseUrl = "https://api.nindo.de/";

        public NindoClient()
        {
            _jsonHelper = new JsonHelper();
        }

        public async Task<Rank[]> GetRankViewsAsync(RankViewsPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}ranks/charts/{requestPlatform}/rankViews/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Rank[]> GetRankViewerAsync(RankViewerPlatform platform, Size size)
        {
            var requestPlatform = platform.ToApiString();
            var requestSize = size.ToApiString();

            var jsonAsStream = await ApiProcessor.GetStats($"{_baseUrl}ranks/charts/{requestPlatform}/rankViewer/{requestSize}");
            var apiData = await _jsonHelper.Deserialise<Rank[]>(jsonAsStream);

            return apiData;
        }
    }
}