using System.Threading.Tasks;
using Nindo.Net.Clients;
using Nindo.Net.Models.Enums;
using Refit;
using Xunit;

namespace Nindo.Net.Tests
{
    public class RefitTests
    {
        [Theory]
        [InlineData(RankViewsPlatform.Youtube, Size.Big)]
        [InlineData(RankViewsPlatform.TikTok, Size.Big)]
        [InlineData(RankViewsPlatform.Youtube, Size.Small)]
        [InlineData(RankViewsPlatform.TikTok, Size.Small)]
        public async Task DemoRun_GetViewsScoreboardAsync(RankViewsPlatform platform, Size size)
        {
            //Arrange
            var test = RestService.For<IRankClient>("https://api.nindo.de/ranks");

            //Act
            var  results = await test.GetViewsScoreboardAsync(platform, size);

            //Assert
            Assert.InRange(results.Content.Length, 10, 100);
        }

        [Theory]
        [InlineData(RankViewerPlatform.Twitch, Size.Big)]
        [InlineData(RankViewerPlatform.Twitch, Size.Small)]
        public async Task DemoRun_GetViewersScoreboardAsync(RankViewerPlatform platform, Size size)
        {
            //Arrange
            var test = RestService.For<IRankClient>("https://api.nindo.de/ranks");

            //Act
            var results = await test.GetViewersScoreboardAsync(platform, size);

            //Assert
            Assert.InRange(results.Content.Length, 10, 100);
        }

        [Theory]
        [InlineData(RankAllPlatform.Youtube, Size.Big)]
        [InlineData(RankAllPlatform.Instagram, Size.Big)]
        [InlineData(RankAllPlatform.TikTok, Size.Big)]
        [InlineData(RankAllPlatform.Twitch, Size.Big)]
        [InlineData(RankAllPlatform.Twitter, Size.Big)]
        [InlineData(RankAllPlatform.Youtube, Size.Small)]
        [InlineData(RankAllPlatform.Instagram, Size.Small)]
        [InlineData(RankAllPlatform.TikTok, Size.Small)]
        [InlineData(RankAllPlatform.Twitch, Size.Small)]
        [InlineData(RankAllPlatform.Twitter, Size.Small)]
        public async Task DemoRun_GetScoreboardAsync(RankAllPlatform platform, Size size)
        {
            //Arrange
            var test = RestService.For<IRankClient>("https://api.nindo.de/ranks");

            //Act
            var results = await test.GetScoreboardAsync(platform, size);

            //Assert
            Assert.InRange(results.Content.Length, 10, 100);
        }

        [Theory]
        [InlineData(RankAllPlatform.Youtube, Size.Big)]
        [InlineData(RankAllPlatform.Instagram, Size.Big)]
        [InlineData(RankAllPlatform.TikTok, Size.Big)]
        [InlineData(RankAllPlatform.Twitch, Size.Big)]
        [InlineData(RankAllPlatform.Twitter, Size.Big)]
        [InlineData(RankAllPlatform.Youtube, Size.Small)]
        [InlineData(RankAllPlatform.Instagram, Size.Small)]
        [InlineData(RankAllPlatform.TikTok, Size.Small)]
        [InlineData(RankAllPlatform.Twitch, Size.Small)]
        [InlineData(RankAllPlatform.Twitter, Size.Small)]
        public async Task DemoRun_GetSubGainScoreboardAsync(RankAllPlatform platform, Size size)
        {
            //Arrange
            var test = RestService.For<IRankClient>("https://api.nindo.de/ranks");

            //Act
            var results = await test.GetSubGainScoreboardAsync(platform, size);

            //Assert
            Assert.InRange(results.Content.Length, 10, 100);
        }

        [Theory]
        [InlineData(RankLikesPlatform.Youtube, Size.Big)]
        [InlineData(RankLikesPlatform.TikTok, Size.Big)]
        [InlineData(RankLikesPlatform.Twitter, Size.Big)]
        [InlineData(RankLikesPlatform.Instagram, Size.Big)]
        [InlineData(RankLikesPlatform.Youtube, Size.Small)]
        [InlineData(RankLikesPlatform.TikTok, Size.Small)]
        [InlineData(RankLikesPlatform.Twitter, Size.Small)]
        [InlineData(RankLikesPlatform.Instagram, Size.Small)]
        public async Task DemoRun_GetLikesScoreboardAsync(RankLikesPlatform platform, Size size)
        {
            //Arrange
            var test = RestService.For<IRankClient>("https://api.nindo.de/ranks");

            //Act
            var results = await test.GetLikesScoreboardAsync(platform, size);

            //Assert
            Assert.InRange(results.Content.Length, 10, 100);
        }

        [Theory]
        [InlineData(RankViewerPlatform.Twitch, Size.Big)]
        [InlineData(RankViewerPlatform.Twitch, Size.Small)]
        public async Task DemoRun_GetPeakViewersScoreboardAsync(RankViewerPlatform platform, Size size)
        {
            //Arrange
            var test = RestService.For<IRankClient>("https://api.nindo.de/ranks");

            //Act
            var results = await test.GetPeakViewersScoreboardAsync(platform, size);

            //Assert
            Assert.InRange(results.Content.Length, 10, 100);
        }

        [Theory]
        [InlineData(RankRetweetsPlatform.Twitter, Size.Big)]
        [InlineData(RankRetweetsPlatform.Twitter, Size.Small)]
        public async Task DemoRun_GetRetweetsScoreboardAsync(RankRetweetsPlatform platform, Size size)
        {
            //Arrange
            var test = RestService.For<IRankClient>("https://api.nindo.de/ranks");

            //Act
            var results = await test.GetRetweetsScoreboardAsync(platform, size);

            //Assert
            Assert.InRange(results.Content.Length, 10, 100);
        }

        [Theory]
        [InlineData(RankAllPlatform.Youtube, Size.Big)]
        [InlineData(RankAllPlatform.Instagram, Size.Big)]
        [InlineData(RankAllPlatform.TikTok, Size.Big)]
        [InlineData(RankAllPlatform.Twitch, Size.Big)]
        [InlineData(RankAllPlatform.Twitter, Size.Big)]
        [InlineData(RankAllPlatform.Youtube, Size.Small)]
        [InlineData(RankAllPlatform.Instagram, Size.Small)]
        [InlineData(RankAllPlatform.TikTok, Size.Small)]
        [InlineData(RankAllPlatform.Twitch, Size.Small)]
        [InlineData(RankAllPlatform.Twitter, Size.Small)]
        public async Task DemoRun_GetSubscribersAsync(RankAllPlatform platform, Size size)
        {
            //Arrange
            var test = RestService.For<IRankClient>("https://api.nindo.de/ranks");

            //Act
            var results = await test.GetSubscribersAsync(platform, size);

            //Assert
            Assert.InRange(results.Content.Length, 10, 100);
        }

        [Fact]
        public async Task DemoRun_GetMilestonesAsync()
        {
            //Arrange
            var test = RestService.For<IRankClient>("https://api.nindo.de/ranks");

            //Act
            var results = await test.GetMilestonesAsync();

            //Assert
            Assert.NotNull(results.Content);
        }

        [Fact]
        public async Task DemoRun_GetPastMilestonesAsync()
        {
            //Arrange
            var test = RestService.For<IRankClient>("https://api.nindo.de/ranks");

            //Act
            var results = await test.GetPastMilestonesAsync();

            //Assert
            Assert.NotNull(results.Content);
        }

        [Fact]
        public async Task DemoRun_SearchUserAsync()
        {
            //Arrange
            var test = RestService.For<ISearchClient>("https://api.nindo.de/search");

            //Act
            var results = await test.SearchUserAsync("MontanaBlack");

            //Assert
            Assert.NotNull(results.Content);
        }

        [Fact]
        public async Task DemoRun_GetViralsAsync()
        {
            //Arrange
            var test = RestService.For<IViralClient>("https://api.nindo.de/viral");

            //Act
            var results = await test.GetViralsAsync();

            //Assert
            Assert.NotNull(results.Content);
        }


        [Theory]
        [InlineData("a8f91412e41308d8ee6a30b3daf963bc")]
        [InlineData("0c57f0ef628f958a06cb2f19af8c269d")]
        [InlineData("fd477856f8ca52f4e900895a06db7b7e")]
        [InlineData("46aac573a0a8bb9741db690a104f4e5e")]
        [InlineData("b21e98604165e556fe0e4272d144331c")]
        [InlineData("c3f37dc22a0a2dfb9a387216c73eaceb")]
        [InlineData("9f255dd5689d452d65dc80377491ef65")]
        [InlineData("d2ebc08a18eda92c8a809c8490ba7b55")]
        [InlineData("21a3a3969aa81e318cd1cc8a549df55e")]
        [InlineData("7a6db13d49fe85ef8d13d4c329317c92")]
        public async Task DemoRun_GetArtistInformationAsync(string userId)
        {
            //Arrange
            var test = RestService.For<IArtistClient>("https://api.nindo.de/artist");

            //Act
            var results = await test.GetArtistInformationAsync(userId);

            //Assert
            Assert.NotNull(results.Content);
        }

        [Fact]
        public async Task DemoRun_GetCouponsAsync()
        {
            //Arrange
            var test = RestService.For<ICouponsClient>("https://api.nindo.de/coupons");

            //Act
            var results = await test.GetCouponsAsync();

            //Assert
            Assert.NotNull(results.Content);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public async Task DemoRun_GetCouponsWithOffsetAsync(int offset)
        {
            //Arrange
            var test = RestService.For<ICouponsClient>("https://api.nindo.de/coupons");

            //Act
            var results = await test.GetCouponsWithOffsetAsync(offset);

            //Assert
            Assert.NotNull(results.Content);
        }

        [Fact]
        public async Task DemoRun_GetCouponBranchesAsync()
        {
            //Arrange
            var test = RestService.For<ICouponsClient>("https://api.nindo.de/coupons");

            //Act
            var results = await test.GetCouponBranchesAsync();

            //Assert
            Assert.NotNull(results.Content);
        }

        [Fact]
        public async Task DemoRun_GetCouponsBrandsAsync()
        {
            //Arrange
            var test = RestService.For<ICouponsClient>("https://api.nindo.de/coupons");

            //Act
            var results = await test.GetCouponBrandsAsync();

            //Assert
            Assert.NotNull(results.Content);
        }

        [Theory]
        [InlineData("Cosmetics & Beauty")]
        [InlineData("Fashion")]
        [InlineData("Sport")]
        public async Task DemoRun_GetCouponsByCategoryAsync(string category)
        {
            //Arrange
            var test = RestService.For<ICouponsClient>("https://api.nindo.de/coupons");

            //Act
            var results = await test.GetCouponsByCategoryAsync(category);

            //Assert
            Assert.NotNull(results.Content);
        }

        [Theory]
        [InlineData("c3f24f319ffd9e82e803ac4b20f295ff")]
        [InlineData("7b8d313719d705353b91a81738c450cc")]
        [InlineData("d6555d5e63cb751f6c094ed2fe8f542a")]
        [InlineData("03d9e19686a02b604b43fe181eaefac0")]
        public async Task DemoRun_GetCouponsByBranchAsync(string branch)
        {
            //Arrange
            var test = RestService.For<ICouponsClient>("https://api.nindo.de/coupons");

            //Act
            var results = await test.GetCouponsByBranchAsync(branch);

            //Assert
            Assert.NotNull(results.Content);
        }
    }
}