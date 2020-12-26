using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Nindo.Net.Helpers;

namespace Nindo.Net.Clients
{
    public class FeedbackClient
    {
        private readonly JsonHelper _jsonHelper;
        private readonly string _baseUrl = "https://api.nindo.de/feedback/";

        public FeedbackClient()
        {
            _jsonHelper = new JsonHelper();
        }

        public async Task<HttpResponseMessage> SubmitCouponAsync(string brand, string artistName, string code, string discount)
        {
            var couponInformation =
                $"\"brand\":\"{brand}\",\"code\":\"{code}\",\"discount\":\"{discount}\",\"artistName\":\"{artistName}\"";
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("content", "{"+couponInformation+"}"),
                new KeyValuePair<string, string>("current", "0"),
                new KeyValuePair<string, string>("type", "newCoupon")

            }); var responseMessage = await ApiProcessor.PostAsync($"{_baseUrl}", content);

            return responseMessage;
        }
    }
}