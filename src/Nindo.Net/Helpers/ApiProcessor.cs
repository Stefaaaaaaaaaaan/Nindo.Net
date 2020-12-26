using System.IO;
using System.Threading.Tasks;

namespace Nindo.Net.Helpers
{
    public class ApiProcessor
    {
        public static async Task<Stream> GetStats(string apiUrl)
        {
            var jsonAsStream = await ApiHelper.ApiClient.GetStreamAsync(apiUrl);
            return jsonAsStream;
        }
    }
}