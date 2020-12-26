using System.Net.Http;
using System.Net.Http.Headers;

namespace Nindo.Net.Helpers
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; } = new HttpClient();

        static ApiHelper()
        {
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}