using System.Threading.Tasks;
using Nindo.Net.Models.Enums;
using Xunit;

namespace Nindo.Net.Tests
{
    public class RankViewTests
    {
        [Theory]
        [InlineData(RankViewsPlatform.Youtube, Size.Big)]
        [InlineData(RankViewsPlatform.TikTok, Size.Big)]
        [InlineData(RankViewsPlatform.Youtube, Size.Small)]
        [InlineData(RankViewsPlatform.TikTok, Size.Small)]
        public async Task DemoRun_GetRankViewsAsync(RankViewsPlatform platform, Size size)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result =await client.GetRankViewsAsync(platform, size);

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RankViewerPlatform.Twitch, Size.Big)]
        [InlineData(RankViewerPlatform.Twitch, Size.Small)]
        public async Task DemoRun_GetRankViewerAsync(RankViewerPlatform platform, Size size)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetRankViewerAsync(platform, size);

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RankAllPlatform.Youtube, Size.Big)]
        [InlineData(RankAllPlatform.Instagram, Size.Big)]
        [InlineData(RankAllPlatform.TikTok, Size.Big)]
        [InlineData(RankAllPlatform.Twitch, Size.Big)]
        [InlineData(RankAllPlatform.Youtube, Size.Small)]
        [InlineData(RankAllPlatform.Instagram, Size.Small)]
        [InlineData(RankAllPlatform.TikTok, Size.Small)]
        [InlineData(RankAllPlatform.Twitch, Size.Small)]
        public async Task DemoRun_GetRankAsync(RankAllPlatform platform, Size size)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetRankAsync(platform, size);

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RankAllPlatform.Youtube, Size.Big)]
        [InlineData(RankAllPlatform.Instagram, Size.Big)]
        [InlineData(RankAllPlatform.TikTok, Size.Big)]
        [InlineData(RankAllPlatform.Twitch, Size.Big)]
        [InlineData(RankAllPlatform.Youtube, Size.Small)]
        [InlineData(RankAllPlatform.Instagram, Size.Small)]
        [InlineData(RankAllPlatform.TikTok, Size.Small)]
        [InlineData(RankAllPlatform.Twitch, Size.Small)]
        public async Task DemoRun_GetRankSubGainAsync(RankAllPlatform platform, Size size)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetRankSubGainAsync(platform, size);

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RankLikesPlatform.Youtube, Size.Big)]
        [InlineData(RankLikesPlatform.Instagram, Size.Big)]
        [InlineData(RankLikesPlatform.TikTok, Size.Big)]
        [InlineData(RankLikesPlatform.Twitter, Size.Big)]
        [InlineData(RankLikesPlatform.Youtube, Size.Small)]
        [InlineData(RankLikesPlatform.Instagram, Size.Small)]
        [InlineData(RankLikesPlatform.TikTok, Size.Small)]
        [InlineData(RankLikesPlatform.Twitter, Size.Small)]
        public async Task DemoRun_GetRankLikesAsync(RankLikesPlatform platform, Size size)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetRankLikesAsync(platform, size);

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RankViewerPlatform.Twitch, Size.Big)]
        [InlineData(RankViewerPlatform.Twitch, Size.Small)]
        public async Task DemoRun_GetRankPeakViewerAsync(RankViewerPlatform platform, Size size)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetRankPeakViewerAsync(platform, size);

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RankRetweets.Twitter, Size.Big)]
        [InlineData(RankRetweets.Twitter, Size.Small)]
        public async Task DemoRun_GetRankRetweetsAsync(RankRetweets platform, Size size)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetRankRetweetsAsync(platform, size);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DemoRun_GetPastMilestonesAsync()
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetPastMilestonesAsync();

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DemoRun_GetMilestonesAsync()
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetMilestonesAsync();

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("montanablack")]
        [InlineData("Alex")]
        public async Task DemoRun_GetSearchAsync(string term)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetSearchAsync(term);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DemoRun_GetViralAsync()
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetViralAsync();

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RankAllPlatform.Youtube, "bd3c3e4b2794394e62d0ba76d0ee0c43")]
        [InlineData(RankAllPlatform.Instagram, "185366e42ce08b1026160fec85dcbce1")]
        [InlineData(RankAllPlatform.TikTok, "1e9c386cea9af5ea3e1e8f9b18abdb20")]
        [InlineData(RankAllPlatform.Twitter, "39580de32b18ddf0cc6ee12de8607db4")]
        [InlineData(RankAllPlatform.Twitch, "a4f19eb4e17bc77edd1e8c187a2cc356")]
        [InlineData(RankAllPlatform.Youtube, "f8c1e101fc05d6da986a14735c8b9fea")]
        [InlineData(RankAllPlatform.Instagram, "445b38b9c054895c29152142aeabc488")]
        [InlineData(RankAllPlatform.TikTok, "a6e66cc4291aff816168df1044ce56ea")]
        [InlineData(RankAllPlatform.Twitter, "39af0e94ee28126f1c80ff19e5c05839")]
        [InlineData(RankAllPlatform.Twitch, "02bd36db184fddfd9c4bfc6afdbbeb3b")]
        public async Task DemoRun_GetChannelInformationAsync(RankAllPlatform platform, string userId)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetChannelInformationAsync(platform, userId);

            //Assert
            Assert.NotNull(result);
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
        public async Task DemoRun_GetArtistAsync(string userId)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetArtistAsync(userId);

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RankAllPlatform.Youtube, "f0f5e45ab17540c5d1164dff24503b1a")]
        [InlineData(RankAllPlatform.TikTok, "1e9c386cea9af5ea3e1e8f9b18abdb20")]
        [InlineData(RankAllPlatform.Instagram, "09594e8d993079fe551a2aa8aacf1fe1")]
        [InlineData(RankAllPlatform.Twitch, "f87d9934c783506a1595e675de0996ad")]
        [InlineData(RankAllPlatform.Twitter, "f31bfbddd8b929e5fd232b5061d0a83b")]

        [InlineData(RankAllPlatform.Youtube, "5383c16fc1471ee057f3e2bf268a43cc")]
        [InlineData(RankAllPlatform.TikTok, "e09249eceec86d098704ad6982ce2c1c")]
        [InlineData(RankAllPlatform.Instagram, "185366e42ce08b1026160fec85dcbce1")]
        [InlineData(RankAllPlatform.Twitch, "cbfa57bcdc0130185b93f8e078c0d104")]
        [InlineData(RankAllPlatform.Twitter, "a70a94eb7b5e2a40cc848cf6ebded7ec")]
        public async Task DemoRun_GetChannelHystoricAsync(RankAllPlatform platform, string userId)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetHistoricChannelAsync(platform, userId);

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(PostsPlatform.TikTok, "1e9c386cea9af5ea3e1e8f9b18abdb20")]
        [InlineData(PostsPlatform.Instagram, "09594e8d993079fe551a2aa8aacf1fe1")]
        [InlineData(PostsPlatform.Twitter, "f31bfbddd8b929e5fd232b5061d0a83b")]

        [InlineData(PostsPlatform.TikTok, "f4a99c87beb995b671952fa98bc96e7e")]
        [InlineData(PostsPlatform.Instagram, "45a1eff68a0b6884d389dbee4d245ce3")]
        [InlineData(PostsPlatform.Twitter, "4c7ba12d66d4190555664ae74a279308")]

        [InlineData(PostsPlatform.TikTok, "5386053644dea65b812e936f2e276434")]
        [InlineData(PostsPlatform.Instagram, "fb1f3d1038140ff87be4b3a0cdd173d5")]
        [InlineData(PostsPlatform.Twitter, "39580de32b18ddf0cc6ee12de8607db4")]
        public async Task DemoRun_GetPostsAsync(PostsPlatform platform, string userId)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetPostsAsync(platform, userId);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DemoRun_GetCouponAsync()
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetCouponsAsync();

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DemoRun_GetCouponBrandsAsync()
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetCouponsBrandsAsync();

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DemoRun_GetCouponBranchesAsync()
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetCouponBranchesAsync();

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Cosmetics%20&%20Beauty")]
        [InlineData("Fashion")]
        [InlineData("Sport")]
        public async Task DemoRun_GetCouponsbySortAsync(string categorie)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetCouponsBySortAsync(categorie);

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("c3f24f319ffd9e82e803ac4b20f295ff")]
        [InlineData("7b8d313719d705353b91a81738c450cc")]
        [InlineData("d6555d5e63cb751f6c094ed2fe8f542a")]
        [InlineData("03d9e19686a02b604b43fe181eaefac0")]
        public async Task DemoRun_GetCouponsForBranchAsync(string id)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetCouponsForBranchAsync(id);

            //Assert
            Assert.NotNull(result);
        }
    }
}