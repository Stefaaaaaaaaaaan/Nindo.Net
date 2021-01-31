using System.Threading.Tasks;
using Nindo.Net.Models;
using Refit;

namespace Nindo.Net.Interfaces
{
    public interface ICouponsClient
    {
        [Get("/")]
        Task<ApiResponse<Coupons>> GetCouponsAsync();

        [Get("/?offset={offset}")]
        Task<ApiResponse<Coupons>> GetCouponsWithOffsetAsync(int offset = 0);

        [Get("/branches")]
        Task<ApiResponse<string[]>> GetCouponBranchesAsync();

        [Get("/brands")]
        Task<ApiResponse<CouponBrands[]>> GetCouponBrandsAsync();

        [Get("/by/{category}")]
        Task<ApiResponse<Coupons>> GetCouponsByCategoryAsync(string category);

        [Get("/for/{branch}")]
        Task<ApiResponse<Coupons>> GetCouponsByBranchAsync(string branch);
    }
}