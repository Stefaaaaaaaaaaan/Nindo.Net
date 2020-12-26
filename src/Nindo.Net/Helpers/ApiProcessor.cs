using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nindo.Net.Helpers
{
    public class ApiProcessor
    {
        public static async Task<Stream> GetAsync(string apiUrl)
        {
            var jsonAsStream = await ApiHelper.ApiClient.GetStreamAsync(apiUrl);
            return jsonAsStream;
        }

        public static async Task<HttpResponseMessage> PostAsync(string apiUrl, HttpContent content)
        {
            var responseMessage = await ApiHelper.ApiClient.PostAsync(apiUrl, content);
            return responseMessage;
        }
    }
}