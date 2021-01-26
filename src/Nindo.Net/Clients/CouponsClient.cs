using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Nindo.Net.Helpers;
using Nindo.Net.Models;

namespace Nindo.Net.Clients
{
    public class CouponsClient
    {
        private readonly JsonHelper _jsonHelper;
        private readonly string _baseUrl = "https://api.nindo.de/coupons";

        public CouponsClient()
        {
            _jsonHelper = new JsonHelper();
        }

        public async Task<Coupons> GetCouponsAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}/");
            var apiData = await _jsonHelper.Deserialise<Coupons>(jsonAsStream);

            return apiData;
        }

        public async Task<Coupons> GetCouponsWithOffsetAsync(int offset = 0)
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}/?offset={offset}");
            var apiData = await _jsonHelper.Deserialise<Coupons>(jsonAsStream);

            return apiData;
        }

        public async Task<string[]> GetCouponBranchesAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}/branches");
            var apiData = await _jsonHelper.Deserialise<string[]>(jsonAsStream);

            return apiData;
        }

        public async Task<CouponBrands[]> GetCouponsBrandsAsync()
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}/brands");
            var apiData = await _jsonHelper.Deserialise<CouponBrands[]>(jsonAsStream);

            return apiData;
        }

        public async Task<Coupons> GetCouponsByCategoryAsync(string category)
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}/by/{category}");
            var apiData = await _jsonHelper.Deserialise<Coupons>(jsonAsStream);

            return apiData;
        }

        public async Task<Coupons> GetCouponsByBranchAsync(string id)
        {
            var jsonAsStream = await ApiProcessor.GetAsync($"{_baseUrl}/for/{id}");
            var apiData = await _jsonHelper.Deserialise<Coupons>(jsonAsStream);

            return apiData;
        }
    }
}