using System.Threading.Tasks;
using Nindo.Net.Interfaces;
using Nindo.Net.Models;
using Refit;

namespace Nindo.Net.Clients
{
    public sealed class CouponsClient
    {
        private readonly ICouponsClient _service;

        public CouponsClient()
        {
            _service = RestService.For<ICouponsClient>("https://api.nindo.de/coupons");
        }

        public async Task<Coupons> GetCouponsAsync()
        {
            var result = await _service.GetCouponsAsync();
            return result.Content;
        }

        public async Task<Coupons> GetCouponsWithOffsetAsync(int offset = 0)
        {
            var result = await _service.GetCouponsWithOffsetAsync(offset);
            return result.Content;
        }

        public async Task<string[]> GetCouponBranchesAsync()
        {
            var result = await _service.GetCouponBranchesAsync();
            return result.Content;
        }

        public async Task<CouponBrands[]> GetCouponBrandsAsync()
        {
            var result = await _service.GetCouponBrandsAsync();
            return result.Content;
        }

        public async Task<Coupons> GetCouponsByCategoryAsync(string category)
        {
            var result = await _service.GetCouponsByCategoryAsync(category);
            return result.Content;
        }

        public async Task<Coupons> GetCouponsByBranchAsync(string branch)
        {
            var result = await _service.GetCouponsByBranchAsync(branch);
            return result.Content;
        }
    }
}