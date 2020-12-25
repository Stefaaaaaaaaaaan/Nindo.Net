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
    }
}